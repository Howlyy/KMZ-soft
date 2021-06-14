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
    public partial class SellForm : Form
    {
        SqlConnection db_con;
        public SellForm()
        {
            InitializeComponent();

            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);
        }

        private void SellSearchBTN_Click(object sender, EventArgs e)
        {
            string combo = SellSearchCB.Text;
            string text = SellSearchTB.Text;


            ware_search(combo, text, KMZsoft.LoggerUserId);
        }

        private void SellWareAddBTN_Click(object sender, EventArgs e)
        {
            //var ware = SellWareDG.SelectedRows[1];

            SellTransactionDG.Columns.Add("ware_name", "ware_name");
            SellTransactionDG.Columns.Add("ware_price", "ware_price");
            SellTransactionDG.Columns.Add("ware_quantity", "ware_quantity");
            
        }

        private void SellWareRemoveBTN_Click(object sender, EventArgs e)
        {

        }

        private void SellWareModQBTN_Click(object sender, EventArgs e)
        {

        }

        private void ware_search(string combo, string text, int id_user)
        {
            DataTable search_dg = new DataTable();

            db_con.Open();



            if (combo == "")
            {
                SqlCommand cmd_ware_search = new SqlCommand("ware_search_view_all", db_con);

                cmd_ware_search.CommandType = CommandType.StoredProcedure;

                cmd_ware_search.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = id_user;

                cmd_ware_search.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(cmd_ware_search);

                sda.Fill(search_dg);

                SellWareDG.DataSource = search_dg;


            }
            else
            {
                SqlCommand cmd_ware_search = new SqlCommand("ware_search_view", db_con);

                cmd_ware_search.CommandType = CommandType.StoredProcedure;

                cmd_ware_search.Parameters.AddWithValue("@combo", SqlDbType.NVarChar).Value = combo;
                cmd_ware_search.Parameters.AddWithValue("@text", SqlDbType.NVarChar).Value = text;
                cmd_ware_search.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = id_user;

                cmd_ware_search.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(cmd_ware_search);
                sda.Fill(search_dg);

                SellWareDG.DataSource = search_dg;
            }


            db_con.Close();
        }
    }
}
