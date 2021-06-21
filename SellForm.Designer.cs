
namespace KMZ_soft
{
    partial class SellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            this.SellSearchCB = new System.Windows.Forms.ComboBox();
            this.SellSearchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SellSearchBTN = new System.Windows.Forms.Button();
            this.SellTransactionDG = new System.Windows.Forms.DataGridView();
            this.SellWareDG = new System.Windows.Forms.DataGridView();
            this.SellWareAddBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SellNettoTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SellBruttoTB = new System.Windows.Forms.TextBox();
            this.SellReceiptBTN = new System.Windows.Forms.Button();
            this.SellInvoiceBTN = new System.Windows.Forms.Button();
            this.SellWareRemoveBTN = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Receipt_print = new System.Drawing.Printing.PrintDocument();
            this.SellQuantityTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.Invoice_print = new System.Drawing.Printing.PrintDocument();
            this.label5 = new System.Windows.Forms.Label();
            this.AddContractorInvoiceTB = new System.Windows.Forms.TextBox();
            this.InvoiceContrBTN = new System.Windows.Forms.Button();
            this.refreshContractorBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SellTransactionDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellWareDG)).BeginInit();
            this.SuspendLayout();
            // 
            // SellSearchCB
            // 
            this.SellSearchCB.FormattingEnabled = true;
            this.SellSearchCB.Items.AddRange(new object[] {
            "Nazwa towaru",
            "Kategoria"});
            this.SellSearchCB.Location = new System.Drawing.Point(209, 31);
            this.SellSearchCB.Name = "SellSearchCB";
            this.SellSearchCB.Size = new System.Drawing.Size(134, 23);
            this.SellSearchCB.TabIndex = 1;
            // 
            // SellSearchTB
            // 
            this.SellSearchTB.Location = new System.Drawing.Point(349, 31);
            this.SellSearchTB.Name = "SellSearchTB";
            this.SellSearchTB.Size = new System.Drawing.Size(148, 23);
            this.SellSearchTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wyszukaj po:";
            // 
            // SellSearchBTN
            // 
            this.SellSearchBTN.Location = new System.Drawing.Point(530, 26);
            this.SellSearchBTN.Name = "SellSearchBTN";
            this.SellSearchBTN.Size = new System.Drawing.Size(125, 30);
            this.SellSearchBTN.TabIndex = 3;
            this.SellSearchBTN.Text = "Wyszukaj";
            this.SellSearchBTN.UseVisualStyleBackColor = true;
            this.SellSearchBTN.Click += new System.EventHandler(this.SellSearchBTN_Click);
            // 
            // SellTransactionDG
            // 
            this.SellTransactionDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellTransactionDG.Location = new System.Drawing.Point(54, 247);
            this.SellTransactionDG.Name = "SellTransactionDG";
            this.SellTransactionDG.RowTemplate.Height = 25;
            this.SellTransactionDG.Size = new System.Drawing.Size(682, 186);
            this.SellTransactionDG.TabIndex = 5;
            // 
            // SellWareDG
            // 
            this.SellWareDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellWareDG.Location = new System.Drawing.Point(54, 77);
            this.SellWareDG.Name = "SellWareDG";
            this.SellWareDG.RowTemplate.Height = 25;
            this.SellWareDG.Size = new System.Drawing.Size(682, 128);
            this.SellWareDG.TabIndex = 5;
            // 
            // SellWareAddBTN
            // 
            this.SellWareAddBTN.Location = new System.Drawing.Point(658, 206);
            this.SellWareAddBTN.Name = "SellWareAddBTN";
            this.SellWareAddBTN.Size = new System.Drawing.Size(44, 30);
            this.SellWareAddBTN.TabIndex = 9;
            this.SellWareAddBTN.Text = "+";
            this.SellWareAddBTN.UseVisualStyleBackColor = true;
            this.SellWareAddBTN.Click += new System.EventHandler(this.SellWareAddBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kwota netto:";
            // 
            // SellNettoTB
            // 
            this.SellNettoTB.Enabled = false;
            this.SellNettoTB.Location = new System.Drawing.Point(426, 449);
            this.SellNettoTB.Name = "SellNettoTB";
            this.SellNettoTB.Size = new System.Drawing.Size(100, 23);
            this.SellNettoTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kwota brutto:";
            // 
            // SellBruttoTB
            // 
            this.SellBruttoTB.Enabled = false;
            this.SellBruttoTB.Location = new System.Drawing.Point(636, 449);
            this.SellBruttoTB.Name = "SellBruttoTB";
            this.SellBruttoTB.Size = new System.Drawing.Size(100, 23);
            this.SellBruttoTB.TabIndex = 14;
            // 
            // SellReceiptBTN
            // 
            this.SellReceiptBTN.Location = new System.Drawing.Point(611, 500);
            this.SellReceiptBTN.Name = "SellReceiptBTN";
            this.SellReceiptBTN.Size = new System.Drawing.Size(125, 51);
            this.SellReceiptBTN.TabIndex = 9;
            this.SellReceiptBTN.Text = "Zapłać i wystaw paragon";
            this.SellReceiptBTN.UseVisualStyleBackColor = true;
            this.SellReceiptBTN.Click += new System.EventHandler(this.SellReceiptBTN_Click);
            // 
            // SellInvoiceBTN
            // 
            this.SellInvoiceBTN.Location = new System.Drawing.Point(448, 500);
            this.SellInvoiceBTN.Name = "SellInvoiceBTN";
            this.SellInvoiceBTN.Size = new System.Drawing.Size(125, 51);
            this.SellInvoiceBTN.TabIndex = 9;
            this.SellInvoiceBTN.Text = "Zapłać i wystaw fakture";
            this.SellInvoiceBTN.UseVisualStyleBackColor = true;
            this.SellInvoiceBTN.Click += new System.EventHandler(this.SellInvoiceBTN_Click);
            // 
            // SellWareRemoveBTN
            // 
            this.SellWareRemoveBTN.Location = new System.Drawing.Point(163, 444);
            this.SellWareRemoveBTN.Name = "SellWareRemoveBTN";
            this.SellWareRemoveBTN.Size = new System.Drawing.Size(125, 30);
            this.SellWareRemoveBTN.TabIndex = 9;
            this.SellWareRemoveBTN.Text = "-";
            this.SellWareRemoveBTN.UseVisualStyleBackColor = true;
            this.SellWareRemoveBTN.Click += new System.EventHandler(this.SellWareRemoveBTN_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Click += new System.EventHandler(this.SellReceiptBTN_Click);
            // 
            // Receipt_print
            // 
            this.Receipt_print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Receipt_print_PrintPage);
            // 
            // SellQuantityTB
            // 
            this.SellQuantityTB.Location = new System.Drawing.Point(541, 211);
            this.SellQuantityTB.Name = "SellQuantityTB";
            this.SellQuantityTB.Size = new System.Drawing.Size(85, 23);
            this.SellQuantityTB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Podaj ilość zaznaczonego towaru:";
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            this.printPreviewDialog2.Click += new System.EventHandler(this.SellInvoiceBTN_Click);
            // 
            // Invoice_print
            // 
            this.Invoice_print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Invoice_print_PrintPage);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Uzupełnij kontrahenta jeżeli wystawiasz fakturę";
            // 
            // AddContractorInvoiceTB
            // 
            this.AddContractorInvoiceTB.Location = new System.Drawing.Point(125, 515);
            this.AddContractorInvoiceTB.Name = "AddContractorInvoiceTB";
            this.AddContractorInvoiceTB.Size = new System.Drawing.Size(197, 23);
            this.AddContractorInvoiceTB.TabIndex = 18;
            this.AddContractorInvoiceTB.TextChanged += new System.EventHandler(this.AddContractorInvoiceTB_TextChanged);
            // 
            // InvoiceContrBTN
            // 
            this.InvoiceContrBTN.Location = new System.Drawing.Point(328, 515);
            this.InvoiceContrBTN.Name = "InvoiceContrBTN";
            this.InvoiceContrBTN.Size = new System.Drawing.Size(39, 25);
            this.InvoiceContrBTN.TabIndex = 19;
            this.InvoiceContrBTN.Text = "+";
            this.InvoiceContrBTN.UseVisualStyleBackColor = true;
            this.InvoiceContrBTN.Click += new System.EventHandler(this.InvoiceContrBTN_Click);
            // 
            // refreshContractorBTN
            // 
            this.refreshContractorBTN.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.refreshContractorBTN.Location = new System.Drawing.Point(373, 515);
            this.refreshContractorBTN.Name = "refreshContractorBTN";
            this.refreshContractorBTN.Size = new System.Drawing.Size(62, 25);
            this.refreshContractorBTN.TabIndex = 20;
            this.refreshContractorBTN.Text = "Odśwież";
            this.refreshContractorBTN.UseVisualStyleBackColor = true;
            this.refreshContractorBTN.Click += new System.EventHandler(this.refreshContractorBTN_Click);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 564);
            this.Controls.Add(this.refreshContractorBTN);
            this.Controls.Add(this.InvoiceContrBTN);
            this.Controls.Add(this.AddContractorInvoiceTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SellQuantityTB);
            this.Controls.Add(this.SellBruttoTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SellNettoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SellSearchCB);
            this.Controls.Add(this.SellSearchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellInvoiceBTN);
            this.Controls.Add(this.SellWareRemoveBTN);
            this.Controls.Add(this.SellReceiptBTN);
            this.Controls.Add(this.SellWareAddBTN);
            this.Controls.Add(this.SellSearchBTN);
            this.Controls.Add(this.SellWareDG);
            this.Controls.Add(this.SellTransactionDG);
            this.Name = "SellForm";
            ((System.ComponentModel.ISupportInitialize)(this.SellTransactionDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellWareDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SellSearchCB;
        private System.Windows.Forms.TextBox SellSearchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SellSearchBTN;
        private System.Windows.Forms.DataGridView SellWareDG;
        private System.Windows.Forms.Button SellWareAddBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SellNettoTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellBruttoTB;
        private System.Windows.Forms.Button SellReceiptBTN;
        private System.Windows.Forms.Button SellInvoiceBTN;
        private System.Windows.Forms.Button SellWareRemoveBTN;
        public  System.Windows.Forms.DataGridView SellTransactionDG;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument Receipt_print;
        private System.Windows.Forms.TextBox SellQuantityTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Drawing.Printing.PrintDocument Invoice_print;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddContractorInvoiceTB;
        private System.Windows.Forms.Button InvoiceContrBTN;
        private System.Windows.Forms.Button refreshContractorBTN;
    }
}