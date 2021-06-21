
namespace KMZ_soft
{
    partial class ContractorsForm
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
            this.ContractorSearchCB = new System.Windows.Forms.ComboBox();
            this.ContractorSearchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContractorModBTN = new System.Windows.Forms.Button();
            this.ContractorDeleteBTN = new System.Windows.Forms.Button();
            this.ContractorAddBTN = new System.Windows.Forms.Button();
            this.ContractorSearchBTN = new System.Windows.Forms.Button();
            this.ContractorSearchDG = new System.Windows.Forms.DataGridView();
            this.InvoiceContractorBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContractorSearchDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ContractorSearchCB
            // 
            this.ContractorSearchCB.FormattingEnabled = true;
            this.ContractorSearchCB.Location = new System.Drawing.Point(298, 25);
            this.ContractorSearchCB.Name = "ContractorSearchCB";
            this.ContractorSearchCB.Size = new System.Drawing.Size(134, 23);
            this.ContractorSearchCB.TabIndex = 12;
            // 
            // ContractorSearchTB
            // 
            this.ContractorSearchTB.Location = new System.Drawing.Point(438, 25);
            this.ContractorSearchTB.Name = "ContractorSearchTB";
            this.ContractorSearchTB.Size = new System.Drawing.Size(148, 23);
            this.ContractorSearchTB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wyszukaj po:";
            // 
            // ContractorModBTN
            // 
            this.ContractorModBTN.Location = new System.Drawing.Point(438, 395);
            this.ContractorModBTN.Name = "ContractorModBTN";
            this.ContractorModBTN.Size = new System.Drawing.Size(125, 43);
            this.ContractorModBTN.TabIndex = 6;
            this.ContractorModBTN.Text = "Modyfikuj kontrahenta";
            this.ContractorModBTN.UseVisualStyleBackColor = true;
            this.ContractorModBTN.Click += new System.EventHandler(this.ContractorModBTN_Click);
            // 
            // ContractorDeleteBTN
            // 
            this.ContractorDeleteBTN.Location = new System.Drawing.Point(275, 395);
            this.ContractorDeleteBTN.Name = "ContractorDeleteBTN";
            this.ContractorDeleteBTN.Size = new System.Drawing.Size(125, 43);
            this.ContractorDeleteBTN.TabIndex = 7;
            this.ContractorDeleteBTN.Text = "Usuń kontrahenta";
            this.ContractorDeleteBTN.UseVisualStyleBackColor = true;
            this.ContractorDeleteBTN.Click += new System.EventHandler(this.ContractorDeleteBTN_Click);
            // 
            // ContractorAddBTN
            // 
            this.ContractorAddBTN.Location = new System.Drawing.Point(105, 395);
            this.ContractorAddBTN.Name = "ContractorAddBTN";
            this.ContractorAddBTN.Size = new System.Drawing.Size(125, 43);
            this.ContractorAddBTN.TabIndex = 8;
            this.ContractorAddBTN.Text = "Dodaj kontrahenta";
            this.ContractorAddBTN.UseVisualStyleBackColor = true;
            this.ContractorAddBTN.Click += new System.EventHandler(this.ContractorAddBTN_Click);
            // 
            // ContractorSearchBTN
            // 
            this.ContractorSearchBTN.Location = new System.Drawing.Point(348, 54);
            this.ContractorSearchBTN.Name = "ContractorSearchBTN";
            this.ContractorSearchBTN.Size = new System.Drawing.Size(125, 30);
            this.ContractorSearchBTN.TabIndex = 9;
            this.ContractorSearchBTN.Text = "Wyszukaj";
            this.ContractorSearchBTN.UseVisualStyleBackColor = true;
            this.ContractorSearchBTN.Click += new System.EventHandler(this.ContractorSearchBTN_Click);
            // 
            // ContractorSearchDG
            // 
            this.ContractorSearchDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractorSearchDG.Location = new System.Drawing.Point(59, 99);
            this.ContractorSearchDG.Name = "ContractorSearchDG";
            this.ContractorSearchDG.RowTemplate.Height = 25;
            this.ContractorSearchDG.Size = new System.Drawing.Size(682, 290);
            this.ContractorSearchDG.TabIndex = 5;
            // 
            // InvoiceContractorBTN
            // 
            this.InvoiceContractorBTN.Location = new System.Drawing.Point(592, 395);
            this.InvoiceContractorBTN.Name = "InvoiceContractorBTN";
            this.InvoiceContractorBTN.Size = new System.Drawing.Size(113, 43);
            this.InvoiceContractorBTN.TabIndex = 13;
            this.InvoiceContractorBTN.Text = "Wybierz do faktury";
            this.InvoiceContractorBTN.UseVisualStyleBackColor = true;
            this.InvoiceContractorBTN.Click += new System.EventHandler(this.InvoiceContractorBTN_Click);
            // 
            // ContractorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InvoiceContractorBTN);
            this.Controls.Add(this.ContractorSearchCB);
            this.Controls.Add(this.ContractorSearchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContractorModBTN);
            this.Controls.Add(this.ContractorDeleteBTN);
            this.Controls.Add(this.ContractorAddBTN);
            this.Controls.Add(this.ContractorSearchBTN);
            this.Controls.Add(this.ContractorSearchDG);
            this.Name = "ContractorsForm";
            this.Text = "Kontrahenci";
            ((System.ComponentModel.ISupportInitialize)(this.ContractorSearchDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ContractorSearchCB;
        private System.Windows.Forms.TextBox ContractorSearchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ContractorModBTN;
        private System.Windows.Forms.Button ContractorDeleteBTN;
        private System.Windows.Forms.Button ContractorAddBTN;
        private System.Windows.Forms.DataGridView ContractorSearchDG;
        public System.Windows.Forms.Button ContractorSearchBTN;
        private System.Windows.Forms.Button InvoiceContractorBTN;
    }
}