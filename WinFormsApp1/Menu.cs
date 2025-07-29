using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gestion_Sage;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gestionEcritureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void declotureEcritureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.Instance.IsConnected())
            {
                DeclotureEcriture form4 = new DeclotureEcriture(DatabaseManager.Instance.GetConnection());
                form4.Show();
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas initialisée.");
            }

        }

        private void décomptabilisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.Instance.IsConnected())
            {
                DecomptabilisationFactureVente form2 = new DecomptabilisationFactureVente(DatabaseManager.Instance.GetConnection());
                form2.Show();
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas initialisée.");
            }
        }

        private void décomptabilisationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.Instance.IsConnected())
            {
                Decomptabilisation_Devalidation_Facture_Vente form3 = new Decomptabilisation_Devalidation_Facture_Vente(DatabaseManager.Instance.GetConnection());
                form3.Show();
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas initialisée.");
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dévalidationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.Instance.IsConnected())
            {
                DevalidationReglement form5 = new DevalidationReglement(DatabaseManager.Instance.GetConnection());
                form5.Show();
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas initialisée.");
            }
        }

        private void décomptabilisationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.Instance.IsConnected())
            {
                DecomptabilisationReglement form6 = new DecomptabilisationReglement(DatabaseManager.Instance.GetConnection());
                form6.Show();
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas initialisée.");
            }
        }

        private void devalidationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.Instance.IsConnected())
            {
                DevalidationFactureVente form7 = new DevalidationFactureVente(DatabaseManager.Instance.GetConnection());
                form7.Show();
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas initialisée.");
            }
        }
    }
}
