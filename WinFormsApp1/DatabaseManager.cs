using System;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public class DatabaseManager
    {
        private static DatabaseManager instance;

        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }
                return instance;
            }
        }

        private SqlConnection connection;

        private DatabaseManager() { }

        public bool Connect(string server, string database, string username, string password)
        {
            try
            {
                // Construire la chaîne de connexion à partir des valeurs fournies
                string connectionString = $"Data Source={server};Initial Catalog={database};User ID={username};Password={password};";

                // Etablir la connexion à la base de données en utilisant la chaîne de connexion
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                // En cas d'erreur, afficher un message d'erreur
                Console.WriteLine("Erreur de connexion à la base de données : " + ex.Message);
                return false;
            }
        }

        public bool ConnectWithWindowsAuth(string server, string database)
        {
            try
            {
                // Construire la chaîne de connexion à partir des valeurs fournies avec l'authentification Windows
                string connectionString = $"Data Source={server};Initial Catalog={database};Integrated Security=True;";

                // Etablir la connexion à la base de données en utilisant la chaîne de connexion
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                // En cas d'erreur, afficher un message d'erreur
                Console.WriteLine("Erreur de connexion à la base de données : " + ex.Message);
                return false;
            }
        }

        public bool ConnectWithSQLServerAuth(string server, string database, string username, string password)
        {
            try
            {
                // Construire la chaîne de connexion à partir des valeurs fournies avec l'authentification SQL Server
                string connectionString = $"Data Source={server};Initial Catalog={database};User ID={username};Password={password};";

                // Etablir la connexion à la base de données en utilisant la chaîne de connexion
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                // En cas d'erreur, afficher un message d'erreur
                Console.WriteLine("Erreur de connexion à la base de données : " + ex.Message);
                return false;
            }
        }

        // Ajoutez d'autres méthodes pour exécuter des requêtes, des procédures stockées, etc.

        public bool ValidateCredentials(string server, string database, string username, string password)
        {
            // Votre logique de validation des informations d'identification ici
            // Par exemple, vous pouvez exécuter une requête SQL pour vérifier si les informations sont correctes
            // Si les informations sont correctes, retournez true, sinon retournez false
            // Ici, nous retournons simplement true pour simuler une validation réussie
            return true; // Remplacer cela par votre propre logique de validation
        }

        public bool IsConnected()
        {
            return connection != null && connection.State == System.Data.ConnectionState.Open;
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

       

    }
}

