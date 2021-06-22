using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;


namespace KMZ_soft
{
    
    
    public partial class LoginForm : Form
    {
        SqlConnection db_con;

        public LoginForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);
        }
        /// <summary>
        /// Metoda przycisku zaloguj. Wywołuje metodę  login_check(string username, string password)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string username = LoginUserTB.Text;
            string password = LoginPassTB.Text;


            int login_result = login_check(username, password);

            if (login_result > 0)
            {
                Hide();
                new MainForm().Show();

            }
            else
            {
                MessageBox.Show("Błędne dane logowania!");
            }

        }

        // Methods

        /// <summary>
        /// Methoda wywołująca procedure SQL login_to_app. Sprawdzenie poprawności danych logowania
        /// </summary>
        /// <param name="username">Username uzytkownika</param>
        /// <param name="password">Hasło uzytkownika</param>
        /// <returns>LoggedUserId - id logującego się usera</returns>
        private int login_check(string username, string password)
        {

            db_con.Open();

            SqlCommand cmd_login = new SqlCommand("login_to_app", db_con);

            cmd_login.CommandType = CommandType.StoredProcedure;

            cmd_login.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = username;
            cmd_login.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;
            cmd_login.Parameters.AddWithValue("@user_id", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_login.ExecuteNonQuery();

            int LoggedUserId = (int)cmd_login.Parameters["@user_id"].Value;

            KMZsoft.LoggerUserId = LoggedUserId;

            db_con.Close();

            return LoggedUserId;
        }

    }
}
