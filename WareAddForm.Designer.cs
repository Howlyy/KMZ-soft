
namespace KMZ_soft.Ware
{
    partial class WareAddForm
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
            this.WareAddQuantityTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WareAddCatTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WareAddTaxTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WareAddPriceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WareAddNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WareAddBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WareAddQuantityTB
            // 
            this.WareAddQuantityTB.Location = new System.Drawing.Point(132, 147);
            this.WareAddQuantityTB.Name = "WareAddQuantityTB";
            this.WareAddQuantityTB.Size = new System.Drawing.Size(151, 23);
            this.WareAddQuantityTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ilość:";
            // 
            // WareAddCatTB
            // 
            this.WareAddCatTB.Location = new System.Drawing.Point(132, 118);
            this.WareAddCatTB.Name = "WareAddCatTB";
            this.WareAddCatTB.Size = new System.Drawing.Size(151, 23);
            this.WareAddCatTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategoria:";
            // 
            // WareAddTaxTB
            // 
            this.WareAddTaxTB.Location = new System.Drawing.Point(132, 89);
            this.WareAddTaxTB.Name = "WareAddTaxTB";
            this.WareAddTaxTB.Size = new System.Drawing.Size(151, 23);
            this.WareAddTaxTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Podatek:";
            // 
            // WareAddPriceTB
            // 
            this.WareAddPriceTB.Location = new System.Drawing.Point(132, 60);
            this.WareAddPriceTB.Name = "WareAddPriceTB";
            this.WareAddPriceTB.Size = new System.Drawing.Size(151, 23);
            this.WareAddPriceTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cena:";
            // 
            // WareAddNameTB
            // 
            this.WareAddNameTB.Location = new System.Drawing.Point(132, 31);
            this.WareAddNameTB.Name = "WareAddNameTB";
            this.WareAddNameTB.Size = new System.Drawing.Size(151, 23);
            this.WareAddNameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwa towaru:";
            // 
            // WareAddBTN
            // 
            this.WareAddBTN.Location = new System.Drawing.Point(89, 212);
            this.WareAddBTN.Name = "WareAddBTN";
            this.WareAddBTN.Size = new System.Drawing.Size(147, 59);
            this.WareAddBTN.TabIndex = 6;
            this.WareAddBTN.Text = "Dodaj";
            this.WareAddBTN.UseVisualStyleBackColor = true;
            this.WareAddBTN.Click += new System.EventHandler(this.WareAddBTN_Click);
            // 
            // WareAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 304);
            this.Controls.Add(this.WareAddQuantityTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WareAddCatTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WareAddTaxTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WareAddPriceTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WareAddNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WareAddBTN);
            this.Name = "WareAddForm";
            this.Text = "Dodawanie towaru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WareAddQuantityTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WareAddCatTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WareAddTaxTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WareAddPriceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WareAddNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WareAddBTN;
    }
}