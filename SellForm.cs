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

        private void SellSearchBTN_Click(object sender, EventArgs e)
        {
            string combo = SellSearchCB.Text;
            string text = SellSearchTB.Text;


            ware_search(combo, text, KMZsoft.LoggerUserId);
        }

        private void SellWareAddBTN_Click(object sender, EventArgs e)
        {

            

            var ware_name = (string)SellWareDG.SelectedCells[0].Value;
            int ware_quantity = Convert.ToInt32(SellQuantityTB.Text);
            var ware_price = (decimal)SellWareDG.SelectedCells[2].Value;
            var ware_tax = (decimal)SellWareDG.SelectedCells[3].Value;
            int id_ware = ware_id(ware_name);

            
                transaction_add(KMZsoft.LoggerUserId, id_ware, ware_quantity, ware_price, ware_tax);
            

            
          
            
        }

        private void SellWareRemoveBTN_Click(object sender, EventArgs e)
        {
            var ware_name = (string)SellTransactionDG.SelectedCells[0].Value;
            int id_ware = ware_id(ware_name);


            db_con.Open();
            DataTable search_dg = new DataTable();

            SqlCommand cmd_trans = new SqlCommand("trans_delete", db_con);

            cmd_trans.CommandType = CommandType.StoredProcedure;

            cmd_trans.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = KMZsoft.LoggerUserId;
            cmd_trans.Parameters.AddWithValue("@id_ware", SqlDbType.Int).Value = id_ware;



            SqlDataAdapter sda = new SqlDataAdapter(cmd_trans);

            sda.Fill(search_dg);

            SellTransactionDG.DataSource = search_dg;
            
            db_con.Close();
        }

        

        private void SellReceiptBTN_Click(object sender, EventArgs e)
        {
           
            printPreviewDialog1.Document = Receipt_print;
            Receipt_print.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Papier A4", 840, 1180);
            printPreviewDialog1.ShowDialog();
            
            db_con.Open();


            SqlCommand cmd_trans = new SqlCommand("transaction_end", db_con);

            cmd_trans.CommandType = CommandType.StoredProcedure;

            cmd_trans.Parameters.AddWithValue("@contractor_id", SqlDbType.Int).Value = ContractorsForm.invoice_contractor_id;
            cmd_trans.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = KMZsoft.LoggerUserId;
            cmd_trans.Parameters.AddWithValue("@receipt", SqlDbType.Bit).Value = 1;

            
            db_con.Close();



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

        private void Receipt_print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 140;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;

            graphics.DrawString("Paragon -> KMZ-SOFT", new Font("Courier New", 20), Brushes.Black, startx, starty);
            offset = offset + (int)fontHeight;
            graphics.DrawString("Data: " + DateTime.Now, font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("-------------------------------------------------- ", font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;
            graphics.DrawString("Towar  |  ilosc  |  Cena  |  Vat  | Kwota Brutto", font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;

          

            foreach (DataRow dr in ((DataTable)SellTransactionDG.DataSource).Rows)
            {

                int columnPosition = startx;

                int rowPosition = starty + offset;

                graphics.DrawString("----------------------------------------- ", font, Brushes.Black, columnPosition, rowPosition);
                rowPosition = rowPosition + 30;


                foreach (DataGridViewColumn dc in SellTransactionDG.Columns)
                {
                    
                    string text = dr[dc.DataPropertyName].ToString();
                    graphics.DrawString(text, this.Font, Brushes.Black, (float)columnPosition + 5, (float)rowPosition ); 

                    
                    columnPosition = columnPosition + 100;
                }

                offset = offset + (int)fontHeight;

            }

            graphics.DrawString("Netto: " + SellNettoTB.Text + "   Brutto: " + SellBruttoTB.Text, font, Brushes.Black, startx+ 100 , starty+ 700);            

        }

        private void netto()
        {
            
            decimal sum = 0;
            for (int i = 0; i < SellTransactionDG.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[1].Value) * Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[2].Value);
            }
            SellNettoTB.Text = sum.ToString();
        }

        private void brutto()
        {

            decimal sum = 0;
            for (int i = 0; i < SellTransactionDG.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[1].Value) * Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[2].Value) * (1 + (Convert.ToDecimal(SellTransactionDG.Rows[i].Cells[3].Value) / 100));
            }
            SellBruttoTB.Text = sum.ToString();
        }

        private void SellInvoiceBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = Invoice_print;
            Invoice_print.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Papier A4", 840, 1180);
            printPreviewDialog2.ShowDialog();
        }

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
            graphics.DrawString("Towar  |  ilosc  |  Cena  |  Vat  | Kwota Brutto", font, Brushes.Black, startx, starty + offset);
            offset = offset + (int)fontHeight;



            foreach (DataRow dr in ((DataTable)SellTransactionDG.DataSource).Rows)
            {

                int columnPosition = startx;

                int rowPosition = starty + offset;

                graphics.DrawString("----------------------------------------- ", font, Brushes.Black, columnPosition, rowPosition);
                rowPosition = rowPosition + 30;


                foreach (DataGridViewColumn dc in SellTransactionDG.Columns)
                {

                    string text = dr[dc.DataPropertyName].ToString();
                    graphics.DrawString(text, this.Font, Brushes.Black, (float)columnPosition + 5, (float)rowPosition);


                    columnPosition = columnPosition + 100;
                }

                offset = offset + (int)fontHeight;

            }

            graphics.DrawString("Netto: " + SellNettoTB.Text + "   Brutto: " + SellBruttoTB.Text, font, Brushes.Black, startx + 100, starty + 700);

        }

        private void AddContractorInvoiceTB_TextChanged(object sender, EventArgs e)
        {
            if (AddContractorInvoiceTB.Text != "")
            {
                SellInvoiceBTN.Visible = true;
            }

            
        }

        private void InvoiceContrBTN_Click(object sender, EventArgs e)
        {
            Form contform = new ContractorsForm();
            contform.Show();


        }

        private void refreshContractorBTN_Click(object sender, EventArgs e)
        {
            AddContractorInvoiceTB.Text = ContractorsForm.invoice_contractor_name;
        }
    }
}
