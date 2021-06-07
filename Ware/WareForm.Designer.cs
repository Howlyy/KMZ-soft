
namespace KMZ_soft
{
    partial class WareForm
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
            this.WareSearchDG = new System.Windows.Forms.DataGridView();
            this.WareSearchBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WareSearchTB = new System.Windows.Forms.TextBox();
            this.WareSearchCB = new System.Windows.Forms.ComboBox();
            this.WareAddBTN = new System.Windows.Forms.Button();
            this.WareDeleteBTN = new System.Windows.Forms.Button();
            this.WareModBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WareSearchDG)).BeginInit();
            this.SuspendLayout();
            // 
            // WareSearchDG
            // 
            this.WareSearchDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WareSearchDG.Location = new System.Drawing.Point(51, 94);
            this.WareSearchDG.Name = "WareSearchDG";
            this.WareSearchDG.RowTemplate.Height = 25;
            this.WareSearchDG.Size = new System.Drawing.Size(682, 290);
            this.WareSearchDG.TabIndex = 0;
            // 
            // WareSearchBTN
            // 
            this.WareSearchBTN.Location = new System.Drawing.Point(340, 49);
            this.WareSearchBTN.Name = "WareSearchBTN";
            this.WareSearchBTN.Size = new System.Drawing.Size(125, 30);
            this.WareSearchBTN.TabIndex = 1;
            this.WareSearchBTN.Text = "Wyszukaj";
            this.WareSearchBTN.UseVisualStyleBackColor = true;
            this.WareSearchBTN.Click += new System.EventHandler(this.WareSearchBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyszukaj po:";
            // 
            // WareSearchTB
            // 
            this.WareSearchTB.Location = new System.Drawing.Point(430, 20);
            this.WareSearchTB.Name = "WareSearchTB";
            this.WareSearchTB.Size = new System.Drawing.Size(148, 23);
            this.WareSearchTB.TabIndex = 3;
            // 
            // WareSearchCB
            // 
            this.WareSearchCB.FormattingEnabled = true;
            this.WareSearchCB.Items.AddRange(new object[] {
            "Nazwa towaru",
            "Kategoria"});
            this.WareSearchCB.Location = new System.Drawing.Point(290, 20);
            this.WareSearchCB.Name = "WareSearchCB";
            this.WareSearchCB.Size = new System.Drawing.Size(134, 23);
            this.WareSearchCB.TabIndex = 4;
            // 
            // WareAddBTN
            // 
            this.WareAddBTN.Location = new System.Drawing.Point(170, 390);
            this.WareAddBTN.Name = "WareAddBTN";
            this.WareAddBTN.Size = new System.Drawing.Size(125, 30);
            this.WareAddBTN.TabIndex = 1;
            this.WareAddBTN.Text = "Dodaj towar";
            this.WareAddBTN.UseVisualStyleBackColor = true;
            this.WareAddBTN.Click += new System.EventHandler(this.WareAddBTN_Click);
            // 
            // WareDeleteBTN
            // 
            this.WareDeleteBTN.Location = new System.Drawing.Point(340, 390);
            this.WareDeleteBTN.Name = "WareDeleteBTN";
            this.WareDeleteBTN.Size = new System.Drawing.Size(125, 30);
            this.WareDeleteBTN.TabIndex = 1;
            this.WareDeleteBTN.Text = "Usuń towar";
            this.WareDeleteBTN.UseVisualStyleBackColor = true;
            this.WareDeleteBTN.Click += new System.EventHandler(this.WareDeleteBTN_Click);
            // 
            // WareModBTN
            // 
            this.WareModBTN.Location = new System.Drawing.Point(503, 390);
            this.WareModBTN.Name = "WareModBTN";
            this.WareModBTN.Size = new System.Drawing.Size(125, 30);
            this.WareModBTN.TabIndex = 1;
            this.WareModBTN.Text = "Modyfikuj towar";
            this.WareModBTN.UseVisualStyleBackColor = true;
            this.WareModBTN.Click += new System.EventHandler(this.WareModBTN_Click);
            // 
            // WareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WareSearchCB);
            this.Controls.Add(this.WareSearchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WareModBTN);
            this.Controls.Add(this.WareDeleteBTN);
            this.Controls.Add(this.WareAddBTN);
            this.Controls.Add(this.WareSearchBTN);
            this.Controls.Add(this.WareSearchDG);
            this.Name = "WareForm";
            this.Text = "WareForm";
            ((System.ComponentModel.ISupportInitialize)(this.WareSearchDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WareSearchDG;
        private System.Windows.Forms.Button WareSearchBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WareSearchTB;
        private System.Windows.Forms.ComboBox WareSearchCB;
        private System.Windows.Forms.Button WareAddBTN;
        private System.Windows.Forms.Button WareDeleteBTN;
        private System.Windows.Forms.Button WareModBTN;
    }
}