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
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings[/*baza*/].ConnectionString);
        }

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

        private int login_check(string username, string password)
        {

            db_con.Open();

            SqlCommand cmd_login = new SqlCommand("Login_proc", db_con);

            cmd_login.CommandType = System.Data.CommandType.StoredProcedure;

            cmd_login.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = username;
            cmd_login.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;
            cmd_login.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_login.ExecuteNonQuery();

            int LoggedUserId = (int)cmd_login.Parameters["@result"].Value; 

            db_con.Close();

            return LoggedUserId;
        }

    }
}
