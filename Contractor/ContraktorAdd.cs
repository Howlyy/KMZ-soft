using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KMZ_soft.Contractor
{
    public partial class ContraktorAdd : Form
    {
        SqlConnection db_con;
        public ContraktorAdd()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString) ;
        }

        private void ContractorAddBTN_Click(object sender, EventArgs e)
        {
            string contractor_name = ContractorAddNameTB.Text;
            string contractor_nip = ContractorAddNipTB.Text;
            string contractor_address = ContractorAddAddressTB.Text;
            int id_user = KMZsoft.LoggerUserId;



            if (add_client(contractor_name, contractor_nip, contractor_address, id_user) == 1)
            {
                MessageBox.Show("Dodano nowego kontrahenta!");
                Hide();

            }
            else
                MessageBox.Show("Taki kontrahent już istnieje!");
        }

        private int add_client(string name, string nip, string address, int id_user)
        {
            db_con.Open();


            SqlCommand cmd_cont_add = new SqlCommand("contractor_add", db_con);
            cmd_cont_add.CommandType = CommandType.StoredProcedure;

            cmd_cont_add.Parameters.AddWithValue("@company_name", SqlDbType.NVarChar).Value = name;
            cmd_cont_add.Parameters.AddWithValue("@nip", SqlDbType.Char).Value = nip;
            cmd_cont_add.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = address;
            cmd_cont_add.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = id_user;
            cmd_cont_add.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_cont_add.ExecuteNonQuery();

            int add_result = (int)cmd_cont_add.Parameters["@result"].Value;

            db_con.Close();
            return add_result;
        }
    }
}
