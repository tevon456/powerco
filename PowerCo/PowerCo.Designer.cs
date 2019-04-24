namespace PowerCo
{
    partial class PowerCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerCo));
            this.CustomerTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameField = new System.Windows.Forms.TextBox();
            this.customerPasswordField = new System.Windows.Forms.TextBox();
            this.customerLoginButton = new System.Windows.Forms.Button();
            this.LoginBackgroundPanel = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LoginBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerTab
            // 
            this.CustomerTab.Controls.Add(this.tabPage1);
            this.CustomerTab.Controls.Add(this.tabPage2);
            this.CustomerTab.Location = new System.Drawing.Point(-5, -1);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.SelectedIndex = 0;
            this.CustomerTab.Size = new System.Drawing.Size(736, 480);
            this.CustomerTab.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Login";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage2.Controls.Add(this.LoginBackgroundPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customerNameField);
            this.panel1.Controls.Add(this.customerPasswordField);
            this.panel1.Controls.Add(this.customerLoginButton);
            this.panel1.Location = new System.Drawing.Point(172, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 335);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "PowerCo Login";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // customerNameField
            // 
            this.customerNameField.BackColor = System.Drawing.Color.MintCream;
            this.customerNameField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customerNameField.Location = new System.Drawing.Point(26, 122);
            this.customerNameField.Name = "customerNameField";
            this.customerNameField.Size = new System.Drawing.Size(339, 26);
            this.customerNameField.TabIndex = 1;
            this.customerNameField.TextChanged += new System.EventHandler(this.customerNameField_TextChanged);
            // 
            // customerPasswordField
            // 
            this.customerPasswordField.BackColor = System.Drawing.Color.MintCream;
            this.customerPasswordField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customerPasswordField.Location = new System.Drawing.Point(27, 196);
            this.customerPasswordField.Name = "customerPasswordField";
            this.customerPasswordField.PasswordChar = '•';
            this.customerPasswordField.Size = new System.Drawing.Size(339, 26);
            this.customerPasswordField.TabIndex = 2;
            // 
            // customerLoginButton
            // 
            this.customerLoginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.customerLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerLoginButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerLoginButton.Location = new System.Drawing.Point(26, 251);
            this.customerLoginButton.Name = "customerLoginButton";
            this.customerLoginButton.Size = new System.Drawing.Size(340, 46);
            this.customerLoginButton.TabIndex = 3;
            this.customerLoginButton.Text = "Login";
            this.customerLoginButton.UseVisualStyleBackColor = false;
            this.customerLoginButton.Click += new System.EventHandler(this.customerLoginButton_Click);
            // 
            // LoginBackgroundPanel
            // 
            this.LoginBackgroundPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginBackgroundPanel.Controls.Add(this.label5);
            this.LoginBackgroundPanel.Controls.Add(this.Header);
            this.LoginBackgroundPanel.Controls.Add(this.PasswordLabel);
            this.LoginBackgroundPanel.Controls.Add(this.NameLabel);
            this.LoginBackgroundPanel.Controls.Add(this.NameField);
            this.LoginBackgroundPanel.Controls.Add(this.PasswordField);
            this.LoginBackgroundPanel.Controls.Add(this.LoginButton);
            this.LoginBackgroundPanel.Location = new System.Drawing.Point(172, 65);
            this.LoginBackgroundPanel.Name = "LoginBackgroundPanel";
            this.LoginBackgroundPanel.Size = new System.Drawing.Size(392, 335);
            this.LoginBackgroundPanel.TabIndex = 7;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(79, 13);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(238, 38);
            this.Header.TabIndex = 5;
            this.Header.Text = "PowerCo Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(23, 173);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 99);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.Color.MintCream;
            this.NameField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameField.Location = new System.Drawing.Point(26, 122);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(339, 26);
            this.NameField.TabIndex = 1;
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.Color.MintCream;
            this.PasswordField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordField.Location = new System.Drawing.Point(27, 196);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '•';
            this.PasswordField.Size = new System.Drawing.Size(339, 26);
            this.PasswordField.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(26, 251);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(340, 46);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Admins";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PowerCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(727, 473);
            this.Controls.Add(this.CustomerTab);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(743, 512);
            this.MinimumSize = new System.Drawing.Size(743, 512);
            this.Name = "PowerCo";
            this.Text = "PowerCo";
            this.Load += new System.EventHandler(this.PowerCo_Load);
            this.CustomerTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LoginBackgroundPanel.ResumeLayout(false);
            this.LoginBackgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl CustomerTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameField;
        private System.Windows.Forms.TextBox customerPasswordField;
        private System.Windows.Forms.Button customerLoginButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel LoginBackgroundPanel;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

