using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;





namespace KMZ_soft.Ware
{
    public partial class WareModForm : Form
    {
        SqlConnection db_con;
        public WareModForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);
            
            WareModNameTB.Text = WareForm.selected_ware_name;
            WareModCatTB.Text = WareForm.selected_ware_category;
            WareModPriceTB.Text = Convert.ToString(WareForm.selected_ware_price) ;
            WareModTaxTB.Text = Convert.ToString(WareForm.selected_ware_tax);
            WareModQuantityTB.Text = Convert.ToString(WareForm.selected_ware_quantity);
        }
        /// <summary>
        /// Metoda użycia przycisku modyfikacji towaru. Wywołuje metode mod_messagebox(string ware_name_mb, string category_mb, decimal price_mb, decimal tax_mb, decimal quantity_mb)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WareModBTN_Click(object sender, EventArgs e)
        {
            string ware_name = WareModNameTB.Text;
            string ware_category = WareModCatTB.Text;
            decimal ware_price = Convert.ToDecimal(WareModPriceTB.Text);
            decimal ware_tax = Convert.ToDecimal(WareModTaxTB.Text);
            decimal ware_quantity = Convert.ToDecimal(WareModQuantityTB.Text);



            mod_messagebox(ware_name, ware_category, ware_price, ware_tax, ware_quantity);
        }
        /// <summary>
        /// Metoda wyświetlająca MessageBoxa Yes/NO pod metodę modyfikowania towaru ware_mod(string ware_name, string category, decimal price, decimal tax, decimal quantity)
        /// </summary>
        /// <param name="ware_name_mb">nazwa towaru</param>
        /// <param name="category_mb">kategoria</param>
        /// <param name="price_mb">cena netto</param>
        /// <param name="tax_mb">vat</param>
        /// <param name="quantity_mb">ilość</param>
        private void mod_messagebox(string ware_name_mb, string category_mb, decimal price_mb, decimal tax_mb, decimal quantity_mb)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz modyfikować " + WareForm.selected_ware_name + " ?", "Powiadomienie", MessageBoxButtons.YesNo) ;

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
        /// <summary>
        /// Metoda wywołująca procedure SQL ware_modyfi
        /// </summary>
        /// <param name="ware_name">nazwa towaru</param>
        /// <param name="category">kategoria</param>
        /// <param name="price">cena netto</param>
        /// <param name="tax">vat</param>
        /// <param name="quantity">ilość</param>
        /// <returns>1 - przeszło 666 - nie przeszło</returns>
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
