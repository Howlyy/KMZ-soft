
namespace KMZ_soft.Contractor
{
    partial class ContraktorAdd
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
            System.Windows.Forms.Label label1;
            this.ContractorAddAddressTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContractorAddNipTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContractorAddNameTB = new System.Windows.Forms.TextBox();
            this.ContractorAddBTN = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 15);
            label1.TabIndex = 19;
            label1.Text = "Nazwa kontrahenta";
            // 
            // ContractorAddAddressTB
            // 
            this.ContractorAddAddressTB.Location = new System.Drawing.Point(143, 90);
            this.ContractorAddAddressTB.Name = "ContractorAddAddressTB";
            this.ContractorAddAddressTB.Size = new System.Drawing.Size(151, 23);
            this.ContractorAddAddressTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Adres:";
            // 
            // ContractorAddNipTB
            // 
            this.ContractorAddNipTB.Location = new System.Drawing.Point(143, 61);
            this.ContractorAddNipTB.MaxLength = 11;
            this.ContractorAddNipTB.Name = "ContractorAddNipTB";
            this.ContractorAddNipTB.Size = new System.Drawing.Size(151, 23);
            this.ContractorAddNipTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nip:";
            // 
            // ContractorAddNameTB
            // 
            this.ContractorAddNameTB.Location = new System.Drawing.Point(143, 32);
            this.ContractorAddNameTB.Name = "ContractorAddNameTB";
            this.ContractorAddNameTB.Size = new System.Drawing.Size(151, 23);
            this.ContractorAddNameTB.TabIndex = 1;
            // 
            // ContractorAddBTN
            // 
            this.ContractorAddBTN.Location = new System.Drawing.Point(81, 136);
            this.ContractorAddBTN.Name = "ContractorAddBTN";
            this.ContractorAddBTN.Size = new System.Drawing.Size(147, 59);
            this.ContractorAddBTN.TabIndex = 4;
            this.ContractorAddBTN.Text = "Dodaj";
            this.ContractorAddBTN.UseVisualStyleBackColor = true;
            this.ContractorAddBTN.Click += new System.EventHandler(this.ContractorAddBTN_Click);
            // 
            // ContraktorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 210);
            this.Controls.Add(this.ContractorAddAddressTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContractorAddNipTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContractorAddNameTB);
            this.Controls.Add(label1);
            this.Controls.Add(this.ContractorAddBTN);
            this.Name = "ContraktorAdd";
            this.Text = "Dodawanie kontrahenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContractorAddAddressTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContractorAddNipTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContractorAddNameTB;
        private System.Windows.Forms.Button ContractorAddBTN;
    }
}