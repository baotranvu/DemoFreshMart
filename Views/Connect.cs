
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Views
{
    class Connect 
    {
        public static SqlConnection connection;
        public static string connectionString;
        public string Createconnect(string user,string password)
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
            b.DataSource = @"ADMIN\SUPERMARKET";
            b.InitialCatalog = "SuperMarket";
            b.IntegratedSecurity = false;
            b.UserID = user;
            b.MultipleActiveResultSets = true;
            b.Password = password;
            connectionString = b.ConnectionString;
            return connectionString;
        }
        public  bool IsServerConnected(string connectionString)
        {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException e)
                {
                     
                    
                    XtraMessageBox.Show(e.Message);
                    return false;
                    
                }
            
        }
        public void ConnectToServer(string user,string pass,Form close)
        {
            string name;
            string s = "SELECT name FROM master.sys.sql_logins WHERE name ='" + user + "'";
            string connectionString = Createconnect(user,pass);
            bool check = IsServerConnected(connectionString);
            if (check)
            {
                SqlCommand command = new SqlCommand(s, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        name = reader.GetString(0);
                    }
                    close.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                    close.Close();
                }
                else
                {
                    XtraMessageBox.Show("Can not connect to server!");
                }
            }
            
            
        }
        

    }


    }

