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
    public partial class ContractorMod : Form
    {
        SqlConnection db_con;
        public ContractorMod()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);

            
        }

        private void ContractorModBTN_Click(object sender, EventArgs e)
        {
            string ware_name = WareForm.selected_ware_name;
            string ware_category = WareForm.selected_ware_category;
            decimal ware_price = WareForm.selected_ware_price;
            decimal ware_tax = WareForm.selected_ware_tax;
            decimal ware_quantity = WareForm.selected_ware_quantity;

            mod_messagebox(ware_name, ware_category, ware_price, ware_tax, ware_quantity);
        }

        
        
        

    

        private void mod_messagebox(string ware_name_mb, string category_mb, decimal price_mb, decimal tax_mb, decimal quantity_mb)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz modyfikować " + WareForm.selected_ware_name + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {


                if (ware_mod(ware_name_mb, category_mb, price_mb, tax_mb, quantity_mb) == 1)
                {
                    MessageBox.Show("Zmodyfikowano towar!");
                    Hide();
                }
                else
                {
                    MessageBox.Show("Bomba");
                }


            }
            else
                MessageBox.Show("Nie zmodyfikowano! Sprawdz dane!");


        }

        private int ware_mod(string ware_name, string category, decimal price, decimal tax, decimal quantity)
        {


            db_con.Open();

            SqlCommand cmd_ware_mod = new SqlCommand("ware_modyfi", db_con);

            cmd_ware_mod.CommandType = CommandType.StoredProcedure;

            cmd_ware_mod.Parameters.AddWithValue("@ware_name", SqlDbType.NVarChar).Value = ware_name;
            cmd_ware_mod.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = price;
            cmd_ware_mod.Parameters.AddWithValue("@tax", SqlDbType.Decimal).Value = tax;
            cmd_ware_mod.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = category;
            cmd_ware_mod.Parameters.AddWithValue("@quantity", SqlDbType.Decimal).Value = quantity;
            cmd_ware_mod.Parameters.AddWithValue("@id_ware", SqlDbType.Int).Value = WareForm.selected_ware_id;
            cmd_ware_mod.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = KMZsoft.LoggerUserId;
            cmd_ware_mod.Parameters.AddWithValue("@result", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_ware_mod.ExecuteNonQuery();

            int mod_result = (int)cmd_ware_mod.Parameters["@result"].Value;


            db_con.Close();

            return mod_result;
        }
    }
}
