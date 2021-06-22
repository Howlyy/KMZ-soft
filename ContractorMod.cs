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

            ContractorModNameTB.Text = ContractorsForm.selected_contractor_name;
            ContractorModNipTB.Text = ContractorsForm.selected_contractor_nip;
            ContractorModAddressTB.Text = ContractorsForm.selected_contractor_address;

        }
        /// <summary>
        /// Metoda użycia przycisku Modyfikuj kontrahenta. Wywołuje metode contractor_mod_messagebox(string name, string nip, string address, int id)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractorModBTN_Click(object sender, EventArgs e)
        {
            string cont_name = ContractorModNameTB.Text;
            string cont_nip = ContractorModNipTB.Text;
            string cont_address = ContractorModAddressTB.Text;
            int cont_id = ContractorsForm.selected_contractor_id;

            contractor_mod_messagebox(cont_name, cont_nip, cont_address, cont_id);
        }

        /// <summary>
        /// Metoda otwierająca MessageBoxa Yes/No. Jeżeli yes to wywołaj metode contractor_mod(string name, string nip, string address, int id)
        /// </summary>
        /// <param name="name">nazwa kontrahenta</param>
        /// <param name="nip">nip</param>
        /// <param name="address">adres</param>
        /// <param name="id">id kontrahenta</param>
        private void contractor_mod_messagebox(string name, string nip, string address, int id)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz modyfikować " + name + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {


                if (contractor_mod(name, nip, address, id) == 1)
                {
                    MessageBox.Show("Zmodyfikowano kontrahenta!");
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
        /// Metoda wywołujaca procedure SQL contractor_modify
        /// </summary>
        /// <param name="name">nazwa kontrahenta</param>
        /// <param name="nip">nip</param>
        /// <param name="address">adres</param>
        /// <param name="id">id kontrahenta</param>
        /// <returns>1 - zmodyfikowan 666- nie zmodyfikowano</returns>
        private int contractor_mod(string name, string nip, string address, int id)
        {


            db_con.Open();

            SqlCommand cmd_cont_mod = new SqlCommand("contractor_modify", db_con);

            cmd_cont_mod.CommandType = CommandType.StoredProcedure;

            cmd_cont_mod.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;
            cmd_cont_mod.Parameters.AddWithValue("@nip", SqlDbType.Char).Value = nip;
            cmd_cont_mod.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = address;
            cmd_cont_mod.Parameters.AddWithValue("@id_contractor", SqlDbType.Int).Value = id;
            cmd_cont_mod.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = KMZsoft.LoggerUserId;
            cmd_cont_mod.Parameters.AddWithValue("@result", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_cont_mod.ExecuteNonQuery();

            int mod_result = (int)cmd_cont_mod.Parameters["@result"].Value;


            db_con.Close();

            return mod_result;
        }
    }
}
