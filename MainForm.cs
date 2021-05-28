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
    public partial class MainForm : Form
    {

        SqlConnection db_con;

        public MainForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["KMZdb"].ConnectionString);
        }

        private void WareCMS_Opening(object sender, CancelEventArgs e)
        {
            Form ware_form = new WareForm();
            ware_form.MdiParent = this;
            ware_form.Show();
        }

        private void ContractorCMS_Opening(object sender, CancelEventArgs e)
        {
            Form contractors_form = new ContractorsForm();
            contractors_form.MdiParent = this;
            contractors_form.Show();
        }

        private void SellCMS_Opening(object sender, CancelEventArgs e)
        {
            Form sell_form = new SellForm();
            sell_form.MdiParent = this;
            sell_form.Show();

        }
    }
}
