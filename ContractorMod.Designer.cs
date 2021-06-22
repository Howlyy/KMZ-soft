
namespace KMZ_soft.Contractor
{
    partial class ContractorMod
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
            this.ContractorModAddressTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContractorModNipTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContractorModNameTB = new System.Windows.Forms.TextBox();
            this.ContractorModBTN = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContractorModAddressTB
            // 
            this.ContractorModAddressTB.Location = new System.Drawing.Point(148, 88);
            this.ContractorModAddressTB.Name = "ContractorModAddressTB";
            this.ContractorModAddressTB.Size = new System.Drawing.Size(151, 23);
            this.ContractorModAddressTB.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Adres:";
            // 
            // ContractorModNipTB
            // 
            this.ContractorModNipTB.Location = new System.Drawing.Point(148, 59);
            this.ContractorModNipTB.Name = "ContractorModNipTB";
            this.ContractorModNipTB.Size = new System.Drawing.Size(151, 23);
            this.ContractorModNipTB.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nip:";
            // 
            // ContractorModNameTB
            // 
            this.ContractorModNameTB.Location = new System.Drawing.Point(148, 30);
            this.ContractorModNameTB.Name = "ContractorModNameTB";
            this.ContractorModNameTB.Size = new System.Drawing.Size(151, 23);
            this.ContractorModNameTB.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 15);
            label1.TabIndex = 26;
            label1.Text = "Nazwa kontrahenta:";
            // 
            // ContractorModBTN
            // 
            this.ContractorModBTN.Location = new System.Drawing.Point(86, 134);
            this.ContractorModBTN.Name = "ContractorModBTN";
            this.ContractorModBTN.Size = new System.Drawing.Size(147, 59);
            this.ContractorModBTN.TabIndex = 24;
            this.ContractorModBTN.Text = "Modyfikuj";
            this.ContractorModBTN.UseVisualStyleBackColor = true;
            this.ContractorModBTN.Click += new System.EventHandler(this.ContractorModBTN_Click);
            // 
            // ContractorMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 207);
            this.Controls.Add(this.ContractorModAddressTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContractorModNipTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContractorModNameTB);
            this.Controls.Add(label1);
            this.Controls.Add(this.ContractorModBTN);
            this.Name = "ContractorMod";
            this.Text = "Modyfikacja kontrahenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContractorModAddressTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContractorModNipTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContractorModNameTB;
        private System.Windows.Forms.Button ContractorModBTN;
    }
}