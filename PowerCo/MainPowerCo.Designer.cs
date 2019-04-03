namespace PowerCo
{
    partial class MainPowerCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPowerCo));
            this.BillGeneration = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CustomerManagement = new System.Windows.Forms.TabControl();
            this.CustomerManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillGeneration
            // 
            this.BillGeneration.BackColor = System.Drawing.Color.RoyalBlue;
            this.BillGeneration.Location = new System.Drawing.Point(4, 22);
            this.BillGeneration.Name = "BillGeneration";
            this.BillGeneration.Padding = new System.Windows.Forms.Padding(3);
            this.BillGeneration.Size = new System.Drawing.Size(805, 431);
            this.BillGeneration.TabIndex = 1;
            this.BillGeneration.Text = "Bill Generation";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Management";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // CustomerManagement
            // 
            this.CustomerManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerManagement.Controls.Add(this.tabPage1);
            this.CustomerManagement.Controls.Add(this.BillGeneration);
            this.CustomerManagement.Location = new System.Drawing.Point(-6, 0);
            this.CustomerManagement.Name = "CustomerManagement";
            this.CustomerManagement.SelectedIndex = 0;
            this.CustomerManagement.Size = new System.Drawing.Size(813, 457);
            this.CustomerManagement.TabIndex = 1;
            // 
            // MainPowerCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPowerCo";
            this.Text = "MainPowerCo";
            this.Load += new System.EventHandler(this.MainPowerCo_Load);
            this.CustomerManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage BillGeneration;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl CustomerManagement;
    }
}