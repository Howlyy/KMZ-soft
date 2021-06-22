
namespace KMZ_soft
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginUserTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.LoginPassTB = new System.Windows.Forms.TextBox();
            this.LoginPassLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginUserTB
            // 
            this.LoginUserTB.Location = new System.Drawing.Point(118, 29);
            this.LoginUserTB.Name = "LoginUserTB";
            this.LoginUserTB.Size = new System.Drawing.Size(142, 23);
            this.LoginUserTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(91, 98);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(141, 67);
            this.LoginBTN.TabIndex = 3;
            this.LoginBTN.Text = "Zaloguj";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // LoginPassTB
            // 
            this.LoginPassTB.Location = new System.Drawing.Point(118, 58);
            this.LoginPassTB.Name = "LoginPassTB";
            this.LoginPassTB.PasswordChar = '*';
            this.LoginPassTB.Size = new System.Drawing.Size(142, 23);
            this.LoginPassTB.TabIndex = 2;
            // 
            // LoginPassLB
            // 
            this.LoginPassLB.AutoSize = true;
            this.LoginPassLB.Location = new System.Drawing.Point(53, 61);
            this.LoginPassLB.Name = "LoginPassLB";
            this.LoginPassLB.Size = new System.Drawing.Size(40, 15);
            this.LoginPassLB.TabIndex = 1;
            this.LoginPassLB.Text = "Hasło:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 189);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.LoginPassLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginPassTB);
            this.Controls.Add(this.LoginUserTB);
            this.Name = "LoginForm";
            this.Text = "Logowanie do aplikacji KMZ-Soft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox LoginPassTB;
        private System.Windows.Forms.Label LoginPassLB;
        private System.Windows.Forms.TextBox LoginUserTB;
    }
}

