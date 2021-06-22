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

    public partial class ContractorsForm : Form
    {
        SqlConnection db_con;

        public static string selected_contractor_name;
        public static string selected_contractor_nip;
        public static string selected_contractor_address;
        public static int selected_contractor_id;

        public static string invoice_contractor_name;
        public static string invoice_contractor_nip;
        public static string invoice_contractor_address;
        public static int invoice_contractor_id;
        public ContractorsForm()
        {

            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);

            if ((KMZsoft.user_permissions(KMZsoft.LoggerUserId)) > 1)
            {
                ContractorAddBTN.Visible = true;
            }
            else
            {
                ContractorAddBTN.Visible = false;
            }
        }
        /// <summary>
        /// Metoda użycia przycisku wyszukaj. Wywołuje metode contractor_search(string combo, string text, int id_user)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractorSearchBTN_Click(object sender, EventArgs e)
        {
            string search_combo = ContractorSearchCB.Text;
            string search_text = ContractorSearchTB.Text;
            int id_user = KMZsoft.LoggerUserId;


            if (search_combo == "")
            {
                contractor_search("", "", id_user);
            }
            else
            {
                contractor_search(search_combo, search_text, id_user);
            }



        }
        /// <summary>
        /// Metoda użycia przycisku dodaj kontrahenta. Otwiera Contractor.ContraktorAdd();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractorAddBTN_Click(object sender, EventArgs e)
        {
            Form contractor_add_form = new Contractor.ContraktorAdd();
            contractor_add_form.Show();
        }
        /// <summary>
        /// Metoda użycia przycisku usuń kontrahenta. Wywołuje metody data_datagrid() jeżeli 0 to delete_messagebox(int contractor_id, string name)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractorDeleteBTN_Click(object sender, EventArgs e)
        {
            if (data_datagrid() == 0)
            {
                delete_messagebox(selected_contractor_id, selected_contractor_name);
            }
            else
            {
                MessageBox.Show("Nie ma czego usuwać! Wyszkuja Kontrahenta!");
            }
        }
        /// <summary>
        /// Metoda użycia przycisku modyfikuj kontrahenta. Wywołuje metody data_datagrid() jeżeli 0 to otwiera Contractor.ContractorMod();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractorModBTN_Click(object sender, EventArgs e)
        {
            if (data_datagrid() == 0)
            {
                Form contractor_form = new Contractor.ContractorMod();
                contractor_form.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego modyfikować! Wyszkuja towar!");
            }
        }
        /// <summary>
        /// Metoda wywołująca procedury SQL contractor_search_view_all lub contractor_search_view w zależności od wartośći combo
        /// </summary>
        /// <param name="combo">wartość z ComboBoxa</param>
        /// <param name="text">wartość z TextBox</param>
        /// <param name="id_user">id usera</param>
        private void contractor_search(string combo, string text, int id_user)
        {
            DataTable search_dg = new DataTable();

            db_con.Open();



            if (combo == "")
            {
                SqlCommand cmd_contractor_search = new SqlCommand("contractor_search_view_all", db_con);

                cmd_contractor_search.CommandType = CommandType.StoredProcedure;

                cmd_contractor_search.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = id_user;

                cmd_contractor_search.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(cmd_contractor_search);

                sda.Fill(search_dg);

                ContractorSearchDG.DataSource = search_dg;


            }
            else
            {
                SqlCommand cmd_contractor_search = new SqlCommand("contractor_search_view", db_con);

                cmd_contractor_search.CommandType = CommandType.StoredProcedure;

                cmd_contractor_search.Parameters.AddWithValue("@combo", SqlDbType.NVarChar).Value = combo;
                cmd_contractor_search.Parameters.AddWithValue("@text", SqlDbType.NVarChar).Value = text;
                cmd_contractor_search.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = id_user;

                cmd_contractor_search.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(cmd_contractor_search);
                sda.Fill(search_dg);

                ContractorSearchDG.DataSource = search_dg;
            }


            db_con.Close();
        }
        /// <summary>
        /// Metoda otwierająca Messageboxa Yes/No. Jeżeli tak to wywołuje metode contractor_delete(contractor_id);
        /// </summary>
        /// <param name="contractor_id"></param>
        /// <param name="name"></param>
        private void delete_messagebox(int contractor_id, string name)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz usunąć " + name + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                contractor_delete(contractor_id);
                MessageBox.Show("Usunięto kontrahenta!");


            }
            else
                MessageBox.Show("Błąd usuwania!");
        }
        /// <summary>
        /// Metoda wywołujaca procedure SQL contractor_delete
        /// </summary>
        /// <param name="contractor_id">id kontrahenta</param>
        /// <returns>1 - usunięto 666 - nie usunięto</returns>
        private int contractor_delete(int contractor_id)
        {

            db_con.Open();


            SqlCommand cmd_delete = new SqlCommand("contractor_delete", db_con);
            cmd_delete.CommandType = CommandType.StoredProcedure;

            cmd_delete.Parameters.AddWithValue("@id_contractor", SqlDbType.NVarChar).Value = contractor_id;
            cmd_delete.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_delete.ExecuteNonQuery();

            int delete_result = (int)cmd_delete.Parameters["@result"].Value;

            db_con.Close();

            return delete_result;
        }
        /// <summary>
        /// Metoda wywołujaca procedure SQL contractor_id.
        /// </summary>
        /// <param name="contractor_nip">nip kontrahenta</param>
        /// <returns>id kontrahenta</returns>
        private int contractor_id(string contractor_nip)
        {
            db_con.Open();

            SqlCommand cmd_contractor_search = new SqlCommand("contractor_id", db_con);

            cmd_contractor_search.CommandType = CommandType.StoredProcedure;


            cmd_contractor_search.Parameters.AddWithValue("@nip", SqlDbType.Char).Value = contractor_nip;
            cmd_contractor_search.Parameters.AddWithValue("@contractor_id", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_contractor_search.ExecuteNonQuery();

            int contractor_id_result = (int)cmd_contractor_search.Parameters["@contractor_id"].Value;

            db_con.Close();

            return contractor_id_result;
        }
        /// <summary>
        /// Metoda wpisująca do zmienych public wartości zaznaczone w datagridzie ContractorSearchDG
        /// </summary>
        /// <returns>0 - zaznaczono 1 - error</returns>
        private int data_datagrid()
        {
            int error;


            try
            {
                var contractor_name = (string)ContractorSearchDG.SelectedCells[0].Value;
                var contractor_nip = (string)ContractorSearchDG.SelectedCells[1].Value;
                var contractor_address = (string)ContractorSearchDG.SelectedCells[2].Value;


                selected_contractor_name = contractor_name;
                selected_contractor_nip = contractor_nip;
                selected_contractor_address = contractor_address;

                selected_contractor_id = contractor_id(selected_contractor_nip);


                error = 0;
            }
            catch
            {
                error = 1;
            }

            return error;
        }
        /// <summary>
        /// Metoda użycia przycisku Wybór do faktury. Dopisuje do zmiennych public z poczatkiem invoice wybrane wartości z datagrida ContractorSearchDG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceContractorBTN_Click(object sender, EventArgs e)
        {
            var contractor_name = (string)ContractorSearchDG.SelectedCells[0].Value;
            var contractor_nip = (string)ContractorSearchDG.SelectedCells[1].Value;
            var contractor_address = (string)ContractorSearchDG.SelectedCells[2].Value;


            invoice_contractor_name = contractor_name;
            invoice_contractor_nip = contractor_nip;
            invoice_contractor_address = contractor_address;

            invoice_contractor_id = contractor_id(invoice_contractor_nip);

            Hide();
        }
    }
}
