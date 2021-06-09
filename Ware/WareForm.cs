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

        public static string selected_ware_name;
        public static string selected_ware_category;
        public static decimal selected_ware_price;
        public static decimal selected_ware_tax;
        public static decimal selected_ware_quantity;
        public static int selected_ware_id;

        public WareForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString) ;

            if ((KMZsoft.user_permissions(KMZsoft.LoggerUserId)) > 1)
            {
                WareAddBTN.Visible = true;
            }
            else
            {
                WareAddBTN.Visible = false;
            }
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
            
            Form ware_add_form = new Ware.WareAddForm();
            ware_add_form.Show();
            
        }
        private void WareDeleteBTN_Click(object sender, EventArgs e)
        {
            if (data_datagrid() == 0)
            {
                delete_messagebox(selected_ware_id);
            }
            else
            {
                MessageBox.Show("Nie ma czego usuwać! Wyszkuja towar!");
            }
        }

        private void WareModBTN_Click(object sender, EventArgs e)
        {
            
            if (data_datagrid() == 0)
            {
                Form ware_mod_form = new Ware.WareModForm();
                ware_mod_form.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego modyfikować! Wyszkuja towar!");
            }

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

        private void delete_messagebox(int id_ware)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz usunąć " + selected_ware_name + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                ware_delete(id_ware);
                MessageBox.Show("Usunięto Towar!");


            }
            else
                MessageBox.Show("Błąd usuwania!");
        }

        private int ware_delete(int ware_id)
        {

            db_con.Open();


            SqlCommand cmd_delete = new SqlCommand("ware_delete", db_con);
            cmd_delete.CommandType = CommandType.StoredProcedure;

            cmd_delete.Parameters.AddWithValue("@id_ware", SqlDbType.NVarChar).Value = ware_id;
            cmd_delete.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_delete.ExecuteNonQuery();

            int delete_result = (int)cmd_delete.Parameters["@result"].Value;

            db_con.Close();

            return delete_result;
        }

        private int ware_id(string ware_name)
        {
            db_con.Open();

            SqlCommand cmd_ware_search = new SqlCommand("ware_id", db_con);

            cmd_ware_search.CommandType = CommandType.StoredProcedure;

            cmd_ware_search.Parameters.AddWithValue("@ware_name", SqlDbType.NVarChar).Value = ware_name;
            cmd_ware_search.Parameters.AddWithValue("@ware_id", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_ware_search.ExecuteNonQuery();

            int ware_id_result = (int)cmd_ware_search.Parameters["@ware_id"].Value;

            db_con.Close();

            return ware_id_result;
        }
        private int data_datagrid()
        {
            int error;
            try
            {


                var ware_name = (string)WareSearchDG.SelectedCells[0].Value; 
                var ware_category = (string)WareSearchDG.SelectedCells[1].Value;
                var ware_price = (decimal)WareSearchDG.SelectedCells[2].Value;
                var ware_tax = (decimal)WareSearchDG.SelectedCells[3].Value;
                var ware_quantity = (decimal)WareSearchDG.SelectedCells[4].Value;

                selected_ware_name = ware_name;
                selected_ware_price = ware_price;
                selected_ware_quantity = ware_quantity;
                selected_ware_tax = ware_tax;
                selected_ware_category = ware_category;

                selected_ware_id = ware_id(selected_ware_name);

                


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
