using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DecomptabilisationReglement : Form
    {
        private SqlConnection connection;

        public DecomptabilisationReglement(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

            // Ajoute un gestionnaire d'événement pour détecter le clic sur une ligne dans le DataGridView
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.RowHeadersVisible = false; // Masquer les en-têtes de ligne
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Remplit automatiquement la zone de recherche avec la valeur de la colonne "N Piece" de la ligne sélectionnée
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells["N°"].Value != null)
                {
                    textBox1.Text = selectedRow.Cells["N°"].Value.ToString();
                }
            }
        }
       

        private void FillDataGridView()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT [RG_Date] as Date, " +
                "[RG_No] as 'N°', " +
                "[RG_Piece] as 'N Piece', " +
                "[RG_Libelle] as Libelle, " +
                "[RG_Reference] as Reference, " +
                "[CT_NumPayeur] as 'Compte Generale', " +
                "[RG_Montant] as Montant, " +
                "[JO_Num] as 'Code Journal', " +
                "CASE WHEN RG_Compta = 1 THEN 'Comptabilisé' END as Comptabilisation, " +
                "CASE WHEN RG_Valide = 1 THEN 'Validé' ELSE 'Non Validé' END as Validation " +
                "FROM F_CREGLEMENT " +
                "WHERE RG_Compta = 1";



                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Fonctionnalité de recherche
            string referenceReglement = textBox1.Text.Trim();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["N°"].Value != null && row.Cells["N°"].Value.ToString() == referenceReglement)
                {
                    dataGridView1.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string referenceReglement = textBox1.Text.Trim();
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand("SAGE_DECOMPTABILIATION_REGLEMENT", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RG_NO", referenceReglement);
                    command.ExecuteNonQuery();
                    MessageBox.Show("La procédure de décomptabilisation de règlement a été exécutée avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'exécution de la procédure de décomptabilisation de règlement : " + ex.Message);
            }
           
        }

        private void DecomptabilisationReglement_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

       
    }
}
