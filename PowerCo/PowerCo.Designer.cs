﻿namespace PowerCo
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginBackgroundPanel = new System.Windows.Forms.Panel();
            this.IconUser = new System.Windows.Forms.PictureBox();
            this.IconLock = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Label();
            this.IconZap = new System.Windows.Forms.PictureBox();
            this.LoginBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconZap)).BeginInit();
            this.SuspendLayout();
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
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.Color.MintCream;
            this.PasswordField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordField.Location = new System.Drawing.Point(27, 196);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(339, 26);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.Color.MintCream;
            this.NameField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameField.Location = new System.Drawing.Point(26, 122);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(339, 26);
            this.NameField.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(52, 96);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(52, 169);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginBackgroundPanel
            // 
            this.LoginBackgroundPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginBackgroundPanel.Controls.Add(this.IconLock);
            this.LoginBackgroundPanel.Controls.Add(this.IconUser);
            this.LoginBackgroundPanel.Controls.Add(this.IconZap);
            this.LoginBackgroundPanel.Controls.Add(this.Header);
            this.LoginBackgroundPanel.Controls.Add(this.PasswordLabel);
            this.LoginBackgroundPanel.Controls.Add(this.NameLabel);
            this.LoginBackgroundPanel.Controls.Add(this.NameField);
            this.LoginBackgroundPanel.Controls.Add(this.PasswordField);
            this.LoginBackgroundPanel.Controls.Add(this.LoginButton);
            this.LoginBackgroundPanel.Location = new System.Drawing.Point(168, 59);
            this.LoginBackgroundPanel.Name = "LoginBackgroundPanel";
            this.LoginBackgroundPanel.Size = new System.Drawing.Size(392, 335);
            this.LoginBackgroundPanel.TabIndex = 6;
            this.LoginBackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // IconUser
            // 
            this.IconUser.Image = global::PowerCo.Properties.Resources.user2;
            this.IconUser.Location = new System.Drawing.Point(27, 97);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(21, 19);
            this.IconUser.TabIndex = 7;
            this.IconUser.TabStop = false;
            // 
            // IconLock
            // 
            this.IconLock.Image = global::PowerCo.Properties.Resources._lock;
            this.IconLock.Location = new System.Drawing.Point(27, 170);
            this.IconLock.Name = "IconLock";
            this.IconLock.Size = new System.Drawing.Size(21, 19);
            this.IconLock.TabIndex = 8;
            this.IconLock.TabStop = false;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(76, 16);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(238, 38);
            this.Header.TabIndex = 5;
            this.Header.Text = "PowerCo Login";
            this.Header.Click += new System.EventHandler(this.label2_Click);
            // 
            // IconZap
            // 
            this.IconZap.Image = global::PowerCo.Properties.Resources.zap;
            this.IconZap.Location = new System.Drawing.Point(57, 25);
            this.IconZap.Name = "IconZap";
            this.IconZap.Size = new System.Drawing.Size(20, 25);
            this.IconZap.TabIndex = 6;
            this.IconZap.TabStop = false;
            // 
            // PowerCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(727, 473);
            this.Controls.Add(this.LoginBackgroundPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(743, 512);
            this.MinimumSize = new System.Drawing.Size(743, 512);
            this.Name = "PowerCo";
            this.Text = "PowerCo";
            this.Load += new System.EventHandler(this.PowerCo_Load);
            this.LoginBackgroundPanel.ResumeLayout(false);
            this.LoginBackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconZap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel LoginBackgroundPanel;
        private System.Windows.Forms.PictureBox IconUser;
        private System.Windows.Forms.PictureBox IconLock;
        private System.Windows.Forms.PictureBox IconZap;
        private System.Windows.Forms.Label Header;
    }
}
