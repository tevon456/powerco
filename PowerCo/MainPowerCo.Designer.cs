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
            this.CustomerManagement = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.premisesNumberField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNumberField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountHoldersNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accountHoldersAddressField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.previousBalanceField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.paymentsField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paymentsDateField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.broughtForwardField = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DashboardTab = new System.Windows.Forms.TabControl();
            this.CustomerManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DashboardTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillGeneration
            // 
            this.BillGeneration.BackColor = System.Drawing.Color.RoyalBlue;
            this.BillGeneration.Location = new System.Drawing.Point(4, 22);
            this.BillGeneration.Name = "BillGeneration";
            this.BillGeneration.Padding = new System.Windows.Forms.Padding(3);
            this.BillGeneration.Size = new System.Drawing.Size(805, 586);
            this.BillGeneration.TabIndex = 1;
            this.BillGeneration.Text = "Bill Generation";
            this.BillGeneration.Click += new System.EventHandler(this.BillGeneration_Click);
            // 
            // CustomerManagement
            // 
            this.CustomerManagement.BackColor = System.Drawing.Color.RoyalBlue;
            this.CustomerManagement.Controls.Add(this.dataGridView1);
            this.CustomerManagement.Controls.Add(this.panel2);
            this.CustomerManagement.Controls.Add(this.panel1);
            this.CustomerManagement.Location = new System.Drawing.Point(4, 22);
            this.CustomerManagement.Name = "CustomerManagement";
            this.CustomerManagement.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerManagement.Size = new System.Drawing.Size(805, 586);
            this.CustomerManagement.TabIndex = 0;
            this.CustomerManagement.Text = "Customer Management";
            this.CustomerManagement.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.accountHoldersAddressField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.accountHoldersNameField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.accountNumberField);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.premisesNumberField);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 583);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Premises Number";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // premisesNumberField
            // 
            this.premisesNumberField.Location = new System.Drawing.Point(19, 69);
            this.premisesNumberField.Name = "premisesNumberField";
            this.premisesNumberField.Size = new System.Drawing.Size(156, 20);
            this.premisesNumberField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Number";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // accountNumberField
            // 
            this.accountNumberField.Location = new System.Drawing.Point(19, 116);
            this.accountNumberField.Name = "accountNumberField";
            this.accountNumberField.Size = new System.Drawing.Size(156, 20);
            this.accountNumberField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account holder\'s Name";
            // 
            // accountHoldersNameField
            // 
            this.accountHoldersNameField.Location = new System.Drawing.Point(19, 165);
            this.accountHoldersNameField.Name = "accountHoldersNameField";
            this.accountHoldersNameField.Size = new System.Drawing.Size(156, 20);
            this.accountHoldersNameField.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Account holder\'s Address";
            // 
            // accountHoldersAddressField
            // 
            this.accountHoldersAddressField.BackColor = System.Drawing.SystemColors.Control;
            this.accountHoldersAddressField.Location = new System.Drawing.Point(19, 215);
            this.accountHoldersAddressField.Name = "accountHoldersAddressField";
            this.accountHoldersAddressField.Size = new System.Drawing.Size(156, 20);
            this.accountHoldersAddressField.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Personal Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Power Readings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(15, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Current Reading";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(18, 351);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(156, 20);
            this.textBox12.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Previous Reading";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(18, 398);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(156, 20);
            this.textBox11.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(15, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Current Usage";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(18, 447);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(156, 20);
            this.textBox10.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(16, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Fuel Adjustment Rate";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(19, 495);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(156, 20);
            this.textBox13.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.broughtForwardField);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.paymentsDateField);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.paymentsField);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.previousBalanceField);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 583);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "PreviousBalance";
            // 
            // previousBalanceField
            // 
            this.previousBalanceField.Location = new System.Drawing.Point(19, 69);
            this.previousBalanceField.Name = "previousBalanceField";
            this.previousBalanceField.Size = new System.Drawing.Size(156, 20);
            this.previousBalanceField.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Payments";
            // 
            // paymentsField
            // 
            this.paymentsField.Location = new System.Drawing.Point(19, 116);
            this.paymentsField.Name = "paymentsField";
            this.paymentsField.Size = new System.Drawing.Size(156, 20);
            this.paymentsField.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Payment Date";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // paymentsDateField
            // 
            this.paymentsDateField.Location = new System.Drawing.Point(19, 165);
            this.paymentsDateField.Name = "paymentsDateField";
            this.paymentsDateField.Size = new System.Drawing.Size(156, 20);
            this.paymentsDateField.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Brought Forward";
            // 
            // broughtForwardField
            // 
            this.broughtForwardField.Location = new System.Drawing.Point(19, 215);
            this.broughtForwardField.Name = "broughtForwardField";
            this.broughtForwardField.Size = new System.Drawing.Size(156, 20);
            this.broughtForwardField.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(19, 351);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 28);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Financials";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 586);
            this.dataGridView1.TabIndex = 12;
            // 
            // DashboardTab
            // 
            this.DashboardTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardTab.Controls.Add(this.CustomerManagement);
            this.DashboardTab.Controls.Add(this.BillGeneration);
            this.DashboardTab.Location = new System.Drawing.Point(-6, 0);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.SelectedIndex = 0;
            this.DashboardTab.Size = new System.Drawing.Size(813, 612);
            this.DashboardTab.TabIndex = 1;
            // 
            // MainPowerCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.DashboardTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPowerCo";
            this.Text = "MainPowerCo";
            this.Load += new System.EventHandler(this.MainPowerCo_Load);
            this.CustomerManagement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DashboardTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage BillGeneration;
        private System.Windows.Forms.TabPage CustomerManagement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox broughtForwardField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paymentsDateField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox paymentsField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox previousBalanceField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox accountHoldersAddressField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountHoldersNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountNumberField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox premisesNumberField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl DashboardTab;
    }
}