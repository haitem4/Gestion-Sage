using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Sage
{
    public partial class DevalidationFactureVente : Form
    {
        private SqlConnection connection; // Ajoutez ce champ pour stocker la connexion

        public DevalidationFactureVente(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection; // Assigner la connexion passée en paramètre au champ de la classe
            // Associer l'événement DataError au gestionnaire d'événements
            dataGridView1.DataError += dataGridView1_DataError;
            dataGridView1.ReadOnly = true;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeadersVisible = false; // Masquer les en-têtes de ligne

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Afficher un message d'erreur personnalisé
            MessageBox.Show("Une erreur s'est produite lors de l'affichage des données. Détails de l'erreur : " + e.Exception.Message);

            // Si nécessaire, effectuez d'autres actions de gestion des erreurs, telles que la journalisation des erreurs ou la manipulation de la cellule en erreur.
            // Par exemple, vous pouvez utiliser les propriétés e.ColumnIndex et e.RowIndex pour obtenir la position de la cellule en erreur.
        }

        private void DevalidationFactureVente_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private async Task FillDataGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
                {
                    await conn.OpenAsync();

                    string query = "SELECT DO_Piece, CT_Intitule AS Client, DO_Date, " +
                                   "CASE DO_Valide WHEN 1 THEN 'Validé' ELSE 'Non Validé' END AS Validation " +
                                   "FROM F_DOCENTETE INNER JOIN F_COMPTET ON F_DOCENTETE.DO_Tiers = F_COMPTET.CT_Num " +
                                   "WHERE DO_Valide = 1";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    await Task.Run(() => adapter.Fill(table));

                    // Vérifier si les colonnes existent avant de les renommer
                    if (table.Columns.Contains("DO_Piece"))
                        table.Columns["DO_Piece"].ColumnName = "Facture";
                    if (table.Columns.Contains("CT_Intitule"))
                        table.Columns["CT_Intitule"].ColumnName = "Client";
                    if (table.Columns.Contains("DO_Date"))
                        table.Columns["DO_Date"].ColumnName = "Date Facture";
                    if (table.Columns.Contains("Validation"))
                        table.Columns["Validation"].ColumnName = "Validation";

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la récupération des données : " + ex.Message);
            }
        }


        private void Executer_btn_Click(object sender, EventArgs e)
        {
            string doPiece = textBox1.Text;

            try
            {
                if (connection != null)
                {
                    using (SqlCommand command = new SqlCommand("SAGE_VENTE_DEVALIDATION_FACTURE", connection))
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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
