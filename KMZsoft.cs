using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KMZ_soft
{

    static class KMZsoft
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        
        static public int LoggerUserId;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        /// <summary>
        /// Metoda wywo³uj¹ca procedurê SQL user_permission.
        /// </summary>
        /// <param name="id_user">int id usera</param>
        /// <returns>int wartoœæ permitów</returns>
        public static int user_permissions(int id_user)
        {
            SqlConnection db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);

            db_con.Open();

            SqlCommand cmd_user_perm = new SqlCommand("user_permission", db_con);

            cmd_user_perm.CommandType = CommandType.StoredProcedure;

            cmd_user_perm.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = id_user;
            cmd_user_perm.Parameters.AddWithValue("@result", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_user_perm.ExecuteNonQuery();

            int permit = (int)cmd_user_perm.Parameters["@result"].Value;

            db_con.Close();

            return permit;
        }


    }
}
