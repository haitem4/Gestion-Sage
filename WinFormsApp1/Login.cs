using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Password_txt.UseSystemPasswordChar = true;

        }


        private void Verifier_btn_Click(object sender, EventArgs e)
        {
            string server = Server_txt.Text;
            string database = Database_txt.Text;
            string username = User_txt.Text;
            string password = Password_txt.Text;

            // Vérification des informations saisies
            bool isValid = DatabaseManager.Instance.ValidateCredentials(server, database, username, password);

            if (isValid)
            {
                MessageBox.Show("Les informations saisies sont correctes.");
            }
            else
            {
                MessageBox.Show("Les informations saisies sont incorrectes.");
            }
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            string server = Server_txt.Text;
            string database = Database_txt.Text;
            string username = User_txt.Text;
            string password = Password_txt.Text;

            // Vérifier l'option d'authentification choisie
            if (radioButton2.Checked)
            {
                // Connexion à la base de données avec l'authentification Windows
                bool isConnected = DatabaseManager.Instance.ConnectWithWindowsAuth(server, database);

                if (isConnected)
                {
                    MessageBox.Show("Connexion réussie !");
                    Hide();
                    new Menu().Show();
                }
                else
                {
                    MessageBox.Show("Erreur de connexion. Vérifiez vos informations.");
                }
            }
            else if (radioButton1.Checked)
            {
                // Connexion à la base de données avec l'authentification SQL Server
                bool isConnected = DatabaseManager.Instance.ConnectWithSQLServerAuth(server, database, username, password);

                if (isConnected)
                {
                    MessageBox.Show("Connexion réussie !");
                    Hide();
                    new Menu().Show();
                }
                else
                {
                    MessageBox.Show("Erreur de connexion. Vérifiez vos informations.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez choisir un mode d'authentification.");
            }
        }


        private void Fermer_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string windowsUsername = Environment.MachineName + "\\" + Environment.UserName;
                User_txt.Text = windowsUsername;
                checkBox1.Visible = false;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                User_txt.Text = "Username";
                Password_txt.Text = "Password";
            }
            else
            {
                User_txt.Text = "";
                Password_txt.Text = "";
            }
            if (radioButton1.Checked)
            {
                // Afficher les champs d'authentification SQL Server
                User_txt.Visible = true;
                Password_txt.Visible = true;

                // Afficher les labels "User" et "Password"
                label3.Visible = true;
                label4.Visible = true;

                // Afficher le checkbox "Afficher"
                checkBox1.Visible = true;

                // Masquer le checkbox "Afficher" si le mot de passe est déjà affiché
              /*  if (!checkBox1.Checked)
                {
                    checkBox1.Visible = false;
                }*/
            }
            else
            {
                // Si l'authentification Windows est sélectionnée, masquer les champs et les labels SQL Server
                User_txt.Visible = true;
                Password_txt.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
                checkBox1.Visible = true;
            }
        }

        private void User_txt_Enter(object sender, EventArgs e)
        {
            if (User_txt.Text == "Username")
            {
                User_txt.Text = "";
            }
        }

        private void Password_txt_Enter(object sender, EventArgs e)
        {
            if (Password_txt.Text == "Password")
            {
                Password_txt.Text = "";
            }
        }

        private void User_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(User_txt.Text))
            {
                User_txt.Text = "Username";
            }
        }

        private void Password_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password_txt.Text))
            {
                Password_txt.Text = "Password";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Si la case à cocher est cochée, afficher le texte du mot de passe
            Password_txt.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;

            // Masquer les champs d'authentification SQL Server
            User_txt.Visible = true;
            Password_txt.Visible = false;
            // Masquer les champs d'authentification SQL Server
            User_txt.Visible = true;
            Password_txt.Visible = false;

            // Masquer les labels "User" et "Password"
            label3.Visible = true;
            label4.Visible = false;

            // Masquer le checkbox "Afficher"
            checkBox1.Visible = false;
        }
        

    }
}
