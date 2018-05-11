using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Configuration;
using System.Windows.Forms;

/// <summary>
/// Singleton odpowiedzialny za inicjowanie połączniea z bazą danych i wykonywania poleceń
/// </summary>
namespace Lab3PSW
{
    public sealed class DatabaseControl
    {
        //---------------------------------------POLA--------------------------------------

        //Połączenie z bazą danych
         private static readonly string provider = ConfigurationManager.AppSettings["provider"];
         private readonly string connectionString = ConfigurationManager.AppSettings["connectionString"];
        
        //Instancja
        //W tym momencie instancja jest wciąż nulem, tu jest błąd
        private static readonly DatabaseControl controlerInstance = new DatabaseControl();

        //factory umożliwia przekazywanie zapytań
        private readonly DbProviderFactory factory= DbProviderFactories.GetFactory(Provider);

        //połączenie
        private  DbConnection connection;

        //------------------------------------WŁAŚCIWOŚCI----------------------------------
        public static DatabaseControl ControlerInstance  => controlerInstance; 

        public static string Provider => provider;

        public string ConnectionString => connectionString;

        public DbProviderFactory Factory => factory;

        public DbConnection Connection { get => connection; set => connection = value; }

        //-----------------------------------KONSTRUKTOR-----------------------------------
        static DatabaseControl()
        {

        }
        private DatabaseControl()
        {
            
            //Konstruktor służy zasadniczo do utworzenia połączenia z bazą danych
            Connection = Factory.CreateConnection();
            
            if (connection == null)
            {
                //TODO:Dać tu wyjątek
                Console.WriteLine("Connection Error");
                Console.ReadLine();
                return;

            }
            
            Connection.ConnectionString = ConnectionString;
           
            
        }
       
       
        //-----------------------------------POZOSTAŁE-----------------------------------
        public User getUserFromDataBase(String login)
        {
            
            DbCommand command = Factory.CreateCommand();
            if (command == null || login.Equals(""))
            {
                
                return null;
            }
                

            
            command.Connection = Connection;
            command.CommandText = "Select * from USERS where login = @login";
            var parameter = command.CreateParameter();
            parameter.ParameterName = "@login";
            parameter.Value = login;
            command.Parameters.Add(parameter);



            Connection.Open();
            DbDataReader dataReader = command.ExecuteReader();
            
            if (!dataReader.HasRows)
            {
                Connection.Close();
                return null;
            }
                
           
            dataReader.Read();
            User user = new User(
                dataReader["imię"].ToString(),
                dataReader["nazwisko"].ToString(),
                dataReader["login"].ToString(),
                dataReader["hasło"].ToString(),
                dataReader["email"].ToString(),
                dataReader["uprawnienia"].ToString(),
                Convert.ToInt32(dataReader["Id"].ToString()));
            Connection.Close();

            return user;
            
        }

        public bool addUserToTheDatabase(User user)
        {
            
            DbCommand command = Factory.CreateCommand();
            if (command == null)
            {
              
                return false;
            }

            command.Connection = Connection;
            command.CommandText = "INSERT INTO USERS (imię,nazwisko,login,hasło,email) VALUES(@name,@nazwisko,@login,@hasło,@email)";

            Dictionary<String,String > parameters=new Dictionary<string, string>()
            {
                {"@name",user.Name },
                {"@nazwisko",user.Surname },
                {"@login",user.Login },
                {"@hasło",user.Password },
                {"@email",user.Email }
            };


            foreach (String key in parameters.Keys)
            {
                var parameter = command.CreateParameter();
                parameter.ParameterName = key;
                parameter.Value = parameters[key];
                command.Parameters.Add(parameter);
            }

            Connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                String messageBoxText;
                String caption;

                if (e.Message.Contains("UQ_LOGIN"))
                {
                    messageBoxText = "User with given login already exists";
                    caption = "Login exists";
                }
                else {
                    messageBoxText = "User with given email already exists";
                    caption = "Email exists";
                }
                
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(messageBoxText, caption, button, icon);
                Connection.Close();
                return false;
            }
            Connection.Close();
            return true;
        }

       

    }
}
