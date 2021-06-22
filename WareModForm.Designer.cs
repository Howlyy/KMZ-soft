
namespace KMZ_soft.Ware
{
    partial class WareModForm
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
            this.WareModBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WareModNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WareModPriceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WareModTaxTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WareModCatTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WareModQuantityTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WareModBTN
            // 
            this.WareModBTN.Location = new System.Drawing.Point(79, 219);
            this.WareModBTN.Name = "WareModBTN";
            this.WareModBTN.Size = new System.Drawing.Size(147, 59);
            this.WareModBTN.TabIndex = 0;
            this.WareModBTN.Text = "Modyfikuj";
            this.WareModBTN.UseVisualStyleBackColor = true;
            this.WareModBTN.Click += new System.EventHandler(this.WareModBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa towaru:";
            // 
            // WareModNameTB
            // 
            this.WareModNameTB.Location = new System.Drawing.Point(119, 37);
            this.WareModNameTB.Name = "WareModNameTB";
            this.WareModNameTB.Size = new System.Drawing.Size(151, 23);
            this.WareModNameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena:";
            // 
            // WareModPriceTB
            // 
            this.WareModPriceTB.Location = new System.Drawing.Point(119, 66);
            this.WareModPriceTB.Name = "WareModPriceTB";
            this.WareModPriceTB.Size = new System.Drawing.Size(151, 23);
            this.WareModPriceTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Podatek:";
            // 
            // WareModTaxTB
            // 
            this.WareModTaxTB.Location = new System.Drawing.Point(119, 95);
            this.WareModTaxTB.Name = "WareModTaxTB";
            this.WareModTaxTB.Size = new System.Drawing.Size(151, 23);
            this.WareModTaxTB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategoria:";
            // 
            // WareModCatTB
            // 
            this.WareModCatTB.Location = new System.Drawing.Point(119, 124);
            this.WareModCatTB.Name = "WareModCatTB";
            this.WareModCatTB.Size = new System.Drawing.Size(151, 23);
            this.WareModCatTB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ilość:";
            // 
            // WareModQuantityTB
            // 
            this.WareModQuantityTB.Location = new System.Drawing.Point(119, 153);
            this.WareModQuantityTB.Name = "WareModQuantityTB";
            this.WareModQuantityTB.Size = new System.Drawing.Size(151, 23);
            this.WareModQuantityTB.TabIndex = 2;
            // 
            // WareModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 324);
            this.Controls.Add(this.WareModQuantityTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WareModCatTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WareModTaxTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WareModPriceTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WareModNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WareModBTN);
            this.Name = "WareModForm";
            this.Text = "Modyfikacja Towaru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WareModBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WareModNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WareModPriceTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WareModTaxTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WareModCatTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WareModQuantityTB;
    }
}