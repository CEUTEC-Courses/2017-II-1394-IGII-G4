using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Data.SqlClient;
using TCS.Entity;

namespace TCS.InitialConfiguration
{
    public class AppConfigurationManager
    {

        public RegistryKey TCSKey;
        private String host;
        private String database;
        private String username;
        private String password;
        private SqlConnection sqlConnection;
        private String sqlconnectionstring;
        private TCS_Entities dbContext;

        public String SQLConnectionString
        {
            get
            {
                return sqlconnectionstring;
            }
        }
        public String Host
        {
            get
            {
                return host;
            }
            set
            {
                host = value;
            }
        }
        public String Database
        {
            get
            {
                return database;
            }
            set
            {
                database = value;
            }
        }
        public String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public TCS_Entities DbContext
        {
            get
            {
                if(dbContext.Database.Connection.State != System.Data.ConnectionState.Open)
                {
                    dbContext.Database.Connection.Open();
                }

                return dbContext;
            }
        }

        private static AppConfigurationManager _instancia;

        private AppConfigurationManager()
        {
            TCSKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\TCS\\DatabaseConnection");
            if(TCSKey == null)
            {
                createKeys();
            }
        }

        private void createKeys()
        {
            Registry.LocalMachine.CreateSubKey(@"SOFTWARE\\TCS\DatabaseConnection");
            TCSKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\TCS\\DatabaseConnection", true);
            TCSKey.SetValue("Host", "");
            TCSKey.SetValue("Database", "");
            TCSKey.SetValue("Username", "");
            TCSKey.SetValue("Password", "");
        }

        public static AppConfigurationManager Instance()
        {
            if (_instancia == null)
                _instancia = new AppConfigurationManager();
            return _instancia;
        }

        public void setConfiguration(String server, String user, String pass, String db)
        {
            Host = server;
            Username = user;
            Password = pass;
            Database = db;          
        }

        public bool checkConfiguration()
        {
            return checkSQLConnection();
        }

        public bool commmitConfiguration()
        {
            try
            {
                TCSKey.SetValue("Host", Host);
                TCSKey.SetValue("Database", Database);
                TCSKey.SetValue("Username", Username);
                TCSKey.SetValue("Password", Password);
                return true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al guardar en registro de Windows. Mensaje : " + ex.Message);
                return false;
            }
            
        }

        private bool checkSQLConnection()
        {
            bool status = false;
            sqlConnection = new SqlConnection(String.Format("Data Source={0};user id={1};password={2};Initial Catalog={3}", Host, Username, Password, Database));
            try
            { 
                sqlConnection.Open();
                status = true;
                sqlconnectionstring = String.Format("Data Source={0};user id={1};password={2};Initial Catalog={3}", Host, Username, Password, Database);
                sqlConnection.Close();
                dbContext = new TCS_Entities();
                dbContext.Database.Connection.ConnectionString = sqlconnectionstring;
                dbContext.Database.Connection.Open();
                if (dbContext.Database.Connection.State != System.Data.ConnectionState.Open)
                    throw new Exception("No se pudo abrir la conexion a la base de datos");
                    
            }
            catch(SqlException myex)
            {
                System.Windows.Forms.MessageBox.Show("Error de conexion a base de datos SQL. Mensaje : " + myex.Message);
                status = false;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error desconocido encontrado. Mensaje : " + ex.Message);
                status = false;
            }
            
            return status;
        }

        public bool leerDatabaseParameters()
        {
            if (TCSKey.GetValue("Host") != null)
                host = TCSKey.GetValue("Host").ToString();
            else
                return false;
            if (TCSKey.GetValue("Database") != null)
                database = TCSKey.GetValue("Database").ToString();
            else
                return false;
            if (TCSKey.GetValue("Username") != null)
                username = TCSKey.GetValue("Username").ToString();
            else
                return false;
            if (TCSKey.GetValue("Password") != null)
                password = TCSKey.GetValue("Password").ToString();
            else
                return false;

            return true;
        }

        public bool checkDatabaseParameters()
        {

            if (leerDatabaseParameters())
            {
                if (String.IsNullOrEmpty(host) || String.IsNullOrEmpty(database) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                    return false;

                return checkSQLConnection();
            }
            else
            {
                return false;
            }
            
        }

    }
}
