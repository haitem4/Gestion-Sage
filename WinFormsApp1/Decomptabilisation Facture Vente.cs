using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class DecomptabilisationFactureVente : Form
    {
        private SqlConnection connection; // Ajoutez ce champ pour stocker la connexion

        public DecomptabilisationFactureVente(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection; // Assigner la connexion passée en paramètre au champ de la classe
            // Associer l'événement DataError au gestionnaire d'événements
            dataGridView1.DataError += dataGridView1_DataError;
            dataGridView1.ReadOnly = true;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.RowHeadersVisible = false; // Masquer les en-têtes de ligne
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Remplit automatiquement la zone de recherche avec la valeur de la colonne "N Piece" de la ligne sélectionnée
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells["Facture"].Value != null)
                {
                    textBox1.Text = selectedRow.Cells["Facture"].Value.ToString();
                }
            }
        }

        private void DècomptabilisationFactureVente_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Afficher un message d'erreur personnalisé
            MessageBox.Show("Une erreur s'est produite lors de l'affichage des données. Détails de l'erreur : " + e.Exception.Message);

            // Si nécessaire, effectuez d'autres actions de gestion des erreurs, telles que la journalisation des erreurs ou la manipulation de la cellule en erreur.
            // Par exemple, vous pouvez utiliser les propriétés e.ColumnIndex et e.RowIndex pour obtenir la position de la cellule en erreur.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Actualiser les données du DataGridView en rechargeant les données de la base de données
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    // Créer une commande SQL pour sélectionner les données de la table F_DOCENTETE
                    string query = "SELECT F_DOCENTETE.DO_Piece, F_COMPTET.CT_Intitule AS Client, F_DOCENTETE.DO_Date, " +
                                   "CASE F_DOCENTETE.DO_Type WHEN 7 THEN 'Comptabilisée' ELSE 'Statut inconnu' END AS DO_Type " +
                                   "FROM F_DOCENTETE " +
                                   "INNER JOIN F_COMPTET ON F_DOCENTETE.DO_Tiers = F_COMPTET.CT_Num " +
                                   "WHERE F_DOCENTETE.DO_Type = 7";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Renommer les colonnes
                    table.Columns["DO_Piece"].ColumnName = "Facture";
                    table.Columns["Client"].ColumnName = "Client"; // Renommée lors de la sélection
                    table.Columns["DO_Date"].ColumnName = "Date Facture";
                    table.Columns["DO_Type"].ColumnName = "Statut";

                    // Remplir le DataGridView
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("La connexion à la base de données n'est pas initialisée ou est fermée.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la récupération des données : " + ex.Message);
            }
        }



        // Code du bouton Exécuter
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DècomptabilisationFactureVente_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FillDataGridView();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string numFacture = textBox1.Text.Trim(); // Récupérer le numéro de facture saisi

            // Parcourir les lignes du DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Facture"].Value != null && row.Cells["Facture"].Value.ToString() == numFacture)
                {
                    // Sélectionner la ligne correspondante
                    dataGridView1.CurrentCell = row.Cells[0]; // Définir la cellule active sur la première colonne de la ligne
                    row.Selected = true;

                    // Sortir de la boucle une fois que la ligne a été trouvée
                    break;
                }
            }
        }

        private void Executer_btn_Click(object sender, EventArgs e)
        {
            string doPiece = textBox1.Text;

            try
            {
                if (connection != null)
                {
                    using (SqlCommand command = new SqlCommand("SAGE_VENTE_DOCOM_FACTURE", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DO_PIECE", doPiece);
                        command.ExecuteNonQuery();
                        MessageBox.Show("La procédure stockée a été exécutée avec succès.");
                    }
                }
                else
                {
                    MessageBox.Show("La connexion à la base de données n'est pas initialisée.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'exécution de la procédure stockée : " + ex.Message);
            }
        }
    }
}
