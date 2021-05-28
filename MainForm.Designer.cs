
namespace KMZ_soft
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Towary = new System.Windows.Forms.ToolStripMenuItem();
            this.WareCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Contractors = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractorCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Sell = new System.Windows.Forms.ToolStripMenuItem();
            this.SellCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Towary,
            this.Contractors,
            this.Sell});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // Towary
            // 
            this.Towary.DropDown = this.WareCMS;
            this.Towary.Name = "Towary";
            this.Towary.Size = new System.Drawing.Size(56, 20);
            this.Towary.Text = "Towary";
            // 
            // WareCMS
            // 
            this.WareCMS.Name = "contextMenuStrip1";
            this.WareCMS.OwnerItem = this.Towary;
            this.WareCMS.Size = new System.Drawing.Size(61, 4);
            this.WareCMS.Opening += new System.ComponentModel.CancelEventHandler(this.WareCMS_Opening);
            // 
            // Contractors
            // 
            this.Contractors.DropDown = this.ContractorCMS;
            this.Contractors.Name = "Contractors";
            this.Contractors.Size = new System.Drawing.Size(83, 20);
            this.Contractors.Text = "Kontrahenci";
            // 
            // ContractorCMS
            // 
            this.ContractorCMS.Name = "ContractorCMS";
            this.ContractorCMS.OwnerItem = this.Contractors;
            this.ContractorCMS.Size = new System.Drawing.Size(61, 4);
            this.ContractorCMS.Opening += new System.ComponentModel.CancelEventHandler(this.ContractorCMS_Opening);
            // 
            // Sell
            // 
            this.Sell.DropDown = this.SellCMS;
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(65, 20);
            this.Sell.Text = "Sprzedaż";
            // 
            // SellCMS
            // 
            this.SellCMS.Name = "SellCMS";
            this.SellCMS.Size = new System.Drawing.Size(61, 4);
            this.SellCMS.Opening += new System.ComponentModel.CancelEventHandler(this.SellCMS_Opening);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "KMZ-Soft";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Towary;
        private System.Windows.Forms.ContextMenuStrip WareCMS;
        private System.Windows.Forms.ToolStripMenuItem Contractors;
        private System.Windows.Forms.ContextMenuStrip ContractorCMS;
        private System.Windows.Forms.ToolStripMenuItem Sell;
        private System.Windows.Forms.ContextMenuStrip SellCMS;
    }
}