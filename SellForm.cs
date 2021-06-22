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
            AddContractorInvoiceTB.Enabled = false;
            SellInvoiceBTN.Visible = false;
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);
        }

        /// <summary>
        /// Metoda przycisku Wyszukaj. Wywołuje metodę ware_search(string combo, string text, int id_user)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellSearchBTN_Click(object sender, EventArgs e)
        {
            string combo = SellSearchCB.Text;
            string text = SellSearchTB.Text;


            ware_search(combo, text, KMZsoft.LoggerUserId);
        }
        /// <summary>
        /// Metoda przycisku Dodaj Towar(+). Wywołuje metodę Transaction_add(int id_user, int id_ware, int quantity, decimal price, decimal tax)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellWareAddBTN_Click(object sender, EventArgs e)
        {

            

            var ware_name = (string)SellWareDG.SelectedCells[0].Value;
            int ware_quantity = Convert.ToInt32(SellQuantityTB.Text);
            var ware_price = (decimal)SellWareDG.SelectedCells[2].Value;
            var ware_tax = (decimal)SellWareDG.SelectedCells[3].Value;
            int id_ware = ware_id(ware_name);

            
            transaction_add(KMZsoft.LoggerUserId, id_ware, ware_quantity, ware_price, ware_tax);
            

            
          
            
        }
        /// <summary>
        /// Metoda przycisku Usuń towar(-). Wywołuje metodę delete_ware_trans(int ware_lp);
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellWareRemoveBTN_Click(object sender, EventArgs e)
        {
            var ware_lp = (int)SellTransactionDG.SelectedCells[0].Value;

            delete_ware_trans(ware_lp);

            
        }


        /// <summary>
        /// Metoda przycisku Zapłać i wystaw paragon. Wywołuje metodę Receipt(), ustawia domyśly format wyfruku oraz wywołuje podgląd printPreviewDialog1.Document = Receipt_print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellReceiptBTN_Click(object sender, EventArgs e)
        {
           
            printPreviewDialog1.Document = Receipt_print;
            Receipt_print.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Papier A4", 840, 1180);
            printPreviewDialog1.ShowDialog();

            Receipt();



        }
        /// <summary>
        /// Metoda przycisku Zapłać i wystaw fakturę. Wywołuje metodę Invoice(), ustawia domyśly format wyfruku oraz wywołuje podgląd printPreviewDialog2.Document = Invoice_print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellInvoiceBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = Invoice_print;
            Invoice_print.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Papier A4", 840, 1180);
            printPreviewDialog2.ShowDialog();

            invoice();
        }
        /// <summary>
        /// Metoda wydruku faktury
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Invoice_print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 140;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;

            graphics.DrawString("Faktura -> KMZ-SOFT", new Font("Courier New", 20), Brushes.Black, startx, starty);
            offset = offset + (int)fontHeight;
            graphics.DrawString("Data: " + DateTime.Now + "      Kasjer: " + KMZsoft.LoggerUserId, font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("-------------------------------------------------- ", font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("Kontrahent: " + ContractorsForm.invoice_contractor_name, font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("Nip: " + ContractorsForm.invoice_contractor_nip, font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("Adres: " + ContractorsForm.invoice_contractor_address, font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("-------------------------------------------------- ", font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("LP |    ", font, Brushes.Black, startx, starty + offset);
            graphics.DrawString("Towar | ", font, Brushes.Black, startx + 85, starty + offset);
            graphics.DrawString("ilosc | ", font, Brushes.Black, startx + 200, starty + offset);
            graphics.DrawString("Netto | ", font, Brushes.Black, startx + 285, starty + offset);
            graphics.DrawString("Vat |   ", font, Brushes.Black, startx + 370, starty + offset);
            graphics.DrawString("Brutto  ", font, Brushes.Black, startx + 455, starty + offset);
            offset = offset + (int)fontHeight;
            offset = offset + (int)fontHeight;



            foreach (DataRow dr in ((DataTable)SellTransactionDG.DataSource).Rows)
            {

                int columnPosition = startx;

                int rowPosition = starty + offset;




                foreach (DataGridViewColumn dc in SellTransactionDG.Columns)
                {

                    string text = dr[dc.DataPropertyName].ToString();
                    graphics.DrawString(text, this.Font, Brushes.Black, (float)columnPosition , (float)rowPosition);


                    columnPosition = columnPosition + 100;
                }

                offset = offset + (int)fontHeight;

            }

            graphics.DrawString("Netto: " + SellNettoTB.Text + "   Brutto: " + SellBruttoTB.Text, font, Brushes.Black, startx + 200, starty + 700);

        }
        /// <summary>
        /// Metoda wydruku paragonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Receipt_print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 140;
            int starty = 40;
            int offset = 30;
            

            graphics.DrawString("Paragon -> KMZ-SOFT", new Font("Courier New", 20), Brushes.Black, startx, starty);
            offset = offset + (int)fontHeight;
            graphics.DrawString("Data: " + DateTime.Now + "      Kasjer: " + KMZsoft.LoggerUserId, font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("-------------------------------------------------- ", font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("LP |    ", font, Brushes.Black, startx , starty + offset);
            graphics.DrawString("Towar | ", font, Brushes.Black, startx + 85, starty + offset);
            graphics.DrawString("ilosc | ", font, Brushes.Black, startx + 200, starty + offset);
            graphics.DrawString("Netto | ", font, Brushes.Black, startx + 285, starty + offset);
            graphics.DrawString("Vat |   ", font, Brushes.Black, startx + 370, starty + offset);
            graphics.DrawString("Brutto  ", font, Brushes.Black, startx + 455, starty + offset);
            offset = offset + (int)fontHeight;



            foreach (DataRow dr in ((DataTable)SellTransactionDG.DataSource).Rows)
            {

                int columnPosition = startx;

                int rowPosition = starty + offset + 30;




                foreach (DataGridViewColumn dc in SellTransactionDG.Columns)
                {

                    string text = dr[dc.DataPropertyName].ToString();
                    graphics.DrawString(text, this.Font, Brushes.Black, (float)columnPosition , (float)rowPosition);


                    columnPosition = columnPosition + 100;
                }

                offset = offset + (int)fontHeight;

            }

            graphics.DrawString("Netto: " + SellNettoTB.Text + "   Brutto: " + SellBruttoTB.Text, font, Brushes.Black, startx + 200, starty + 700);

        }

        /// <summary>
        /// Metoda przycisku dodania kontrahenta do faktury (+)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceContrBTN_Click(object sender, EventArgs e)
        {
            Form contform = new ContractorsForm();
            contform.Show();


        }
        /// <summary>
        /// Metoda odświeżająca nazwę kontahenta w AddContractorInvoiceTB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshContractorBTN_Click(object sender, EventArgs e)
        {
            AddContractorInvoiceTB.Text = ContractorsForm.invoice_contractor_name;
        }

        /// <summary>
        /// Metoda wywołująca procedury SQL ware_search_view lub ware_search_view_all bazująca na wartości combo
        /// </summary>
        /// <param name="combo">Wartość ComboBoxa/param>
        /// <param name="text">Wartość TextBoxa</param>
        /// <param name="id_user">int id_user</param>
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

        /// <summary>
        /// Metoda wywołująca procedurę SQL ware_id
        /// </summary>
        /// <param name="ware_name">Nazwa towaru</param>
        /// <returns>int id towaru z bazy</returns>
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
        /// <summary>
        /// Metoda wywołująca procedurę sql transaction_2.
        /// </summary>
        /// <param name="id_user">int id_usera</param>
        /// <param name="id_ware">int id towaru</param>
        /// <param name="quantity">int ilość</param>
        /// <param name="price">decimal kwota netto</param>
        /// <param name="tax">decimal VAT</param>
        private void transaction_add(int id_user, int id_ware, int quantity, decimal price, decimal tax)
        {

            db_con.Open();


            SqlCommand cmd_trans = new SqlCommand("transaction_2", db_con);

            cmd_trans.CommandType = CommandType.StoredProcedure;

            cmd_trans.Parameters.AddWithValue("@user_id", SqlDbType.Int).Value = id_user;
            cmd_trans.Parameters.AddWithValue("@id_ware", SqlDbType.Int).Value = id_ware;
            cmd_trans.Parameters.AddWithValue("@quantity", SqlDbType.Int).Value = quantity;
            cmd_trans.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = price;
            cmd_trans.Parameters.AddWithValue("@tax", SqlDbType.Decimal).Value = tax;

           

            DataTable search_dg = new DataTable();

            
            SqlDataAdapter sda = new SqlDataAdapter(cmd_trans);

            sda.Fill(search_dg);

            SellTransactionDG.DataSource = search_dg;
            
            

            db_con.Close();

            

            netto();
            brutto();
            }

       
        /// <summary>
        /// Metoda oblicająca wartość netto bieżącego koszyka
        /// </summary>
        private void netto()
        {
            
            decimal sum = 0;
            for (int i = 0; i < SellTransactionDG.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[2].Value) * Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[3].Value);
            }
            sum = Math.Round(sum, 2, MidpointRounding.AwayFromZero);
            SellNettoTB.Text = sum.ToString();
        }
        /// <summary>
        /// Metoda oblicająca wartość brutto bieżącego koszyka
        /// </summary>
        private void brutto()
        {

            decimal sum = 0;
            for (int i = 0; i < SellTransactionDG.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[2].Value) * Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[3].Value) * (1 + (Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[4].Value) / 100));
            }
            sum = Math.Round(sum, 2, MidpointRounding.AwayFromZero);
            SellBruttoTB.Text = sum.ToString();
        }

        /// <summary>
        /// Metoda ustawiająca SellInvoiceBTN.Visible = true przy zmianie textu w AddContractorInvoiceTB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContractorInvoiceTB_TextChanged(object sender, EventArgs e)
        {
            if (AddContractorInvoiceTB.Text != "")
            {
                SellInvoiceBTN.Visible = true;
            }

            
        }

        /// <summary>
        /// Metoda wywołujaca procedure SQL trans_delete. Usuwa towar z koszyka
        /// </summary>
        /// <param name="ware_lp">int LP towaru</param>
        private void delete_ware_trans(int ware_lp)
        {
            db_con.Open();
            DataTable search_dg = new DataTable();

            SqlCommand cmd_trans = new SqlCommand("trans_delete", db_con);

            cmd_trans.CommandType = CommandType.StoredProcedure;

            cmd_trans.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = KMZsoft.LoggerUserId;
            cmd_trans.Parameters.AddWithValue("@lp", SqlDbType.Int).Value = ware_lp;



            SqlDataAdapter sda = new SqlDataAdapter(cmd_trans);

            sda.Fill(search_dg);

            SellTransactionDG.DataSource = search_dg;

            db_con.Close();

            netto();
            brutto();
        }

        /// <summary>
        /// Metoda wywołująca procedurę SQL transactions_end.
        /// </summary>
        private void invoice()
        {
            db_con.Open();


            SqlCommand cmd_trans = new SqlCommand("transactions_end", db_con);

            cmd_trans.CommandType = CommandType.StoredProcedure;

            cmd_trans.Parameters.AddWithValue("@contractor_id", SqlDbType.Int).Value = ContractorsForm.invoice_contractor_id;
            cmd_trans.Parameters.AddWithValue("@user_id", SqlDbType.Int).Value = KMZsoft.LoggerUserId;
            cmd_trans.Parameters.AddWithValue("@receipt", SqlDbType.Bit).Value = 0;

            cmd_trans.ExecuteNonQuery();

            db_con.Close();
        }
        /// <summary>
        /// Metoda wywołująca procedurę SQL transactions_end.
        /// </summary>
        private void Receipt()
        {
            db_con.Open();


            SqlCommand cmd_trans = new SqlCommand("transactions_end", db_con);

            cmd_trans.CommandType = CommandType.StoredProcedure;

            cmd_trans.Parameters.AddWithValue("@contractor_id", SqlDbType.Int).Value = "";
            cmd_trans.Parameters.AddWithValue("@user_id", SqlDbType.Int).Value = KMZsoft.LoggerUserId;
            cmd_trans.Parameters.AddWithValue("@receipt", SqlDbType.Bit).Value = 1;

            cmd_trans.ExecuteNonQuery();

            db_con.Close();
        }
    }
}
