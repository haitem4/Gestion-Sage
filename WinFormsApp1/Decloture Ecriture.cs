using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DeclotureEcriture : Form
    {
        private SqlConnection connection;

        public DeclotureEcriture(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            // Attacher l'événement DataError du DataGridView
            dataGridView1.DataError += dataGridView1_DataError;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.RowHeadersVisible = false; // Masquer les en-têtes de ligne
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Remplit automatiquement la zone de recherche avec la valeur de la colonne "N Piece" de la ligne sélectionnée
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells["N_pieces"].Value != null)
                {
                    textBox1.Text = selectedRow.Cells["N_pieces"].Value.ToString();
                }
            }
        }
        private void Executer_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void DeclotureEcriture_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            try
            {
                // Vérifier si la connexion est fermée avant de l'ouvrir
                if (connection.State == ConnectionState.Closed)
                {
                    // Ouvrir la connexion
                    connection.Open();
                }

                // Requête SQL pour sélectionner les champs de la table F_ECRITUREC
                string query = "SELECT JO_Num AS Journal, " +
                               "CASE EC_Cloture WHEN 0 THEN 'Non Clôturé' ELSE 'Clôturé' END AS Cloture, " +
                               "EC_Date AS Date_Ecriture, " +
                               "EC_Piece AS N_pieces, " +
                               "EC_RefPiece AS 'Num Facture', " +
                               "EC_Intitule AS Intitulé, " +
                               "CT_Num AS 'Compte_Tiers', " +
                               "CG_Num AS 'Comte_Général', " +
                               "EC_Montant AS Montant, " +
                               "EC_Sens AS Sens, " +
                               "EC_Lettrage AS Lettrage " +
                               "FROM F_ECRITUREC " +
                               "WHERE EC_Cloture = 1";

                // Créer un adaptateur de données et remplir un DataTable avec les résultats de la requête
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Afficher les données dans le DataGridView
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            FillDataGridView();

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Gérer l'événement DataError en affichant un message d'erreur personnalisé
            MessageBox.Show("Une erreur est survenue lors du chargement des données dans le DataGridView: " + e.Exception.Message);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string numFacture = textBox1.Text.Trim(); // Récupérer le numéro de facture saisi

            // Parcourir les lignes du DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["N_pieces"].Value != null && row.Cells["N_pieces"].Value.ToString() == numFacture)
                {
                    // Sélectionner la ligne correspondante
                    dataGridView1.CurrentCell = row.Cells[0]; // Définir la cellule active sur la première colonne de la ligne
                    row.Selected = true;

                    // Sortir de la boucle une fois que la ligne a été trouvée
                    break;
                }
            }

          
        }
        private void Executer_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string doPiece = textBox1.Text; // Remplacez "Votre numéro de pièce" par le numéro de pièce approprié

                // Vérifier si la connexion est fermée avant de l'ouvrir
                if (connection.State == ConnectionState.Closed)
                {
                    // Ouvrir la connexion
                    connection.Open();
                }

                // Appel de la procédure stockée
                using (SqlCommand command = new SqlCommand("SAGE_DECLOTURE_ECRITURE_JOURNAL", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DO_PIECE", doPiece);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Procédure exécutée avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                // Assurez-vous de fermer la connexion après utilisation
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
   
}

