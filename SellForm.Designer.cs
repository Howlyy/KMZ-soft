
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SellWareRemoveBTN = new System.Windows.Forms.Button();
            this.SellWareModQBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SellTransactionDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellWareDG)).BeginInit();
            this.SuspendLayout();
            // 
            // SellSearchCB
            // 
            this.SellSearchCB.FormattingEnabled = true;
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
            this.SellWareAddBTN.Location = new System.Drawing.Point(671, 211);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(470, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(611, 501);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // SellWareRemoveBTN
            // 
            this.SellWareRemoveBTN.Location = new System.Drawing.Point(54, 444);
            this.SellWareRemoveBTN.Name = "SellWareRemoveBTN";
            this.SellWareRemoveBTN.Size = new System.Drawing.Size(125, 30);
            this.SellWareRemoveBTN.TabIndex = 9;
            this.SellWareRemoveBTN.Text = "-";
            this.SellWareRemoveBTN.UseVisualStyleBackColor = true;
            this.SellWareRemoveBTN.Click += new System.EventHandler(this.SellWareRemoveBTN_Click);
            // 
            // SellWareModQBTN
            // 
            this.SellWareModQBTN.Location = new System.Drawing.Point(195, 444);
            this.SellWareModQBTN.Name = "SellWareModQBTN";
            this.SellWareModQBTN.Size = new System.Drawing.Size(125, 30);
            this.SellWareModQBTN.TabIndex = 9;
            this.SellWareModQBTN.Text = "MOD";
            this.SellWareModQBTN.UseVisualStyleBackColor = true;
            this.SellWareModQBTN.Click += new System.EventHandler(this.SellWareModQBTN_Click);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.SellBruttoTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SellNettoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SellSearchCB);
            this.Controls.Add(this.SellSearchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellWareModQBTN);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SellWareRemoveBTN);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SellWareAddBTN);
            this.Controls.Add(this.SellSearchBTN);
            this.Controls.Add(this.SellWareDG);
            this.Controls.Add(this.SellTransactionDG);
            this.Name = "SellForm";
            this.Text = "SellForm";
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
        private System.Windows.Forms.DataGridView SellTransactionDG;
        private System.Windows.Forms.DataGridView SellWareDG;
        private System.Windows.Forms.Button SellWareAddBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SellNettoTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellBruttoTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button SellWareRemoveBTN;
        private System.Windows.Forms.Button SellWareModQBTN;
    }
}