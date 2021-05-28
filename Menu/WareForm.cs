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
    public partial class WareForm : Form
    {
        SqlConnection db_con;

        string selected_ware_name;
        string selected_ware_category;
        double selected_ware_price;
        int selected_ware_tax;
        int selected_ware_quantity;
        int selected_ware_id;

        public WareForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString) ;
        }

        private void WareSearchBTN_Click(object sender, EventArgs e)
        {
            string search_combo = WareSearchCB.Text;
            string search_text = WareSearchTB.Text;
            int id_user = KMZsoft.LoggerUserId;


            if (search_combo == "")
            {
                ware_search("","",id_user);
            }
            else
            {
                ware_search(search_combo, search_text, id_user);
            }

           
        }
       
        private void WareAddBTN_Click(object sender, EventArgs e)
        {
            Form ware_add_form = new Wa
        }
        private void WareDeleteBTN_Click(object sender, EventArgs e)
        {

        }

        private void WareModBTN_Click(object sender, EventArgs e)
        {

        }

        //metods

        private void ware_search(string combo, string text, int id_user)
        {
            DataTable search_dg = new DataTable(); 

            db_con.Open();

            

            if(combo == "")
            {
                SqlCommand cmd_ware_search = new SqlCommand("ware_search_view_all", db_con);

                cmd_ware_search.CommandType = CommandType.StoredProcedure;

                cmd_ware_search.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = id_user;

                cmd_ware_search.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(cmd_ware_search);
                
                sda.Fill(search_dg);

                WareSearchDG.DataSource = search_dg;


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

                WareSearchDG.DataSource = search_dg;
            }


            db_con.Close();
        }

        private double ware_add(string ware_name, string category, double price, int tax, int quantity)
        {

            int id_user = KMZsoft.LoggerUserId;

            SqlCommand cmd_ware_search = new SqlCommand("ware_add", db_con);

            cmd_ware_search.CommandType = CommandType.StoredProcedure;

            cmd_ware_search.Parameters.AddWithValue("@ware_name", SqlDbType.NVarChar).Value = ware_name;
            cmd_ware_search.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = category;
            cmd_ware_search.Parameters.AddWithValue("@price", SqlDbType.SmallMoney).Value = price;
            cmd_ware_search.Parameters.AddWithValue("@tax", SqlDbType.Decimal).Value = tax;
            cmd_ware_search.Parameters.AddWithValue("@quantity", SqlDbType.Decimal).Value = quantity;
            cmd_ware_search.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = id_user;
            cmd_ware_search.Parameters.AddWithValue("@result", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_ware_search.ExecuteNonQuery();

            int ware_add_result = (int)cmd_ware_search.Parameters["@result"].Value;

            if(ware_add_result == 666)
            {
                MessageBox.Show("Taki towar już istnieje! Sprawdz dane");
            }
            else
            {
                MessageBox.Show("Poprawnie dodano towar!");
                Hide();
            }
            
        }

        private int ware_id(string ware_name)
        {

            SqlCommand cmd_ware_search = new SqlCommand("ware_id", db_con);

            cmd_ware_search.CommandType = CommandType.StoredProcedure;

            cmd_ware_search.Parameters.AddWithValue("@ware_name", SqlDbType.NVarChar).Value = ware_name;
            cmd_ware_search.Parameters.AddWithValue("@ware_id", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_ware_search.ExecuteNonQuery();

            int ware_id_result = (int)cmd_ware_search.Parameters["@ware_id"].Value;

            return ware_id_result;
        }
        private int data_datagrid()
        {
            int error;
            try
            {
                string ware_name = (string)WareSearchDG.SelectedCells[0].Value;

                selected_ware_name = (string)WareSearchDG.SelectedCells[0].Value; ;
                selected_ware_category = (string)WareSearchDG.SelectedCells[1].Value;
                selected_ware_price = (double)WareSearchDG.SelectedCells[2].Value;
                selected_ware_tax = (int)WareSearchDG.SelectedCells[3].Value;
                selected_ware_quantity = (int)WareSearchDG.SelectedCells[4].Value;
                selected_ware_id = ware_id(ware_name);


                error = 0;
            }
            catch (Exception e)
            {

                error = 1;
            }

            return error;
        }
    }
}
