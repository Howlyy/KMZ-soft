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
    public partial class WareAddForm : Form
    {
        SqlConnection db_con;

        public WareAddForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);
        }
        /// <summary>
        /// Metoda użycia przycisku Dodaj towar. Wywołuje metode ware_add(string ware_name, string category, double price, int tax, int quantity)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WareAddBTN_Click(object sender, EventArgs e)
        {
            string ware_name = WareAddNameTB.Text;
            double ware_price = Convert.ToDouble(WareAddPriceTB.Text);
            int ware_tax = Convert.ToInt32(WareAddTaxTB.Text);
            string ware_category = WareAddCatTB.Text;
            int ware_quantity = Convert.ToInt32(WareAddQuantityTB.Text);


            ware_add(ware_name, ware_category, ware_price, ware_tax,  ware_quantity);
        }
        /// <summary>
        /// Metoda wywołująca procedure SQL ware_add
        /// </summary>
        /// <param name="ware_name"> nazwa towaru</param>
        /// <param name="category">kategoria</param>
        /// <param name="price">cena netto</param>
        /// <param name="tax">VAT</param>
        /// <param name="quantity">ilosc</param>
        private void ware_add(string ware_name, string category, double price, int tax, int quantity)
        {
            db_con.Open();
            
            
            
            SqlCommand cmd_ware_search = new SqlCommand("ware_add", db_con);

            cmd_ware_search.CommandType = CommandType.StoredProcedure;

            cmd_ware_search.Parameters.AddWithValue("@ware_name", SqlDbType.NVarChar).Value = ware_name;
            cmd_ware_search.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = category;
            cmd_ware_search.Parameters.AddWithValue("@price", SqlDbType.SmallMoney).Value = price;
            cmd_ware_search.Parameters.AddWithValue("@tax", SqlDbType.Decimal).Value = tax;
            cmd_ware_search.Parameters.AddWithValue("@quantity", SqlDbType.Decimal).Value = quantity;
            cmd_ware_search.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = KMZsoft.LoggerUserId;
            cmd_ware_search.Parameters.AddWithValue("@result", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_ware_search.ExecuteNonQuery();

            int ware_add_result = (int)cmd_ware_search.Parameters["@result"].Value;

            if (ware_add_result == 666)
            {
                MessageBox.Show("Taki towar już istnieje! Sprawdz dane");
            }
            else
            {
                MessageBox.Show("Poprawnie dodano towar!");
                Hide();
            }
            db_con.Close();
        }

    }
}
