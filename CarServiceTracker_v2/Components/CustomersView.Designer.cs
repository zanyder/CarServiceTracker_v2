namespace CarServiceTracker_v2.Components
{
    partial class CustomersView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblPhoneNumber = new Label();
            textBox1 = new TextBox();
            lblEmailAddress = new Label();
            btnAddNew = new Button();
            lblLicense = new Label();
            maskedTextBox1 = new MaskedTextBox();
            txtPhoneNumber = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(316, 201);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 15;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(434, 201);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(151, 27);
            txtFirstName.TabIndex = 16;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(316, 241);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 17;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(434, 241);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(151, 27);
            txtLastName.TabIndex = 18;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(316, 279);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 19;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 315);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 21;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(316, 315);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(103, 20);
            lblEmailAddress.TabIndex = 22;
            lblEmailAddress.Text = "Email Address";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(369, 412);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(140, 40);
            btnAddNew.TabIndex = 23;
            btnAddNew.Text = "Create &Customer";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Location = new Point(316, 354);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(86, 20);
            lblLicense.TabIndex = 25;
            lblLicense.Text = "License NO.";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(434, 354);
            maskedTextBox1.Mask = "A9999-99999-99999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(151, 27);
            maskedTextBox1.TabIndex = 27;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(434, 276);
            txtPhoneNumber.Mask = "(999) 000-0000";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(151, 27);
            txtPhoneNumber.TabIndex = 28;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPhoneNumber);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblLicense);
            Controls.Add(btnAddNew);
            Controls.Add(lblEmailAddress);
            Controls.Add(textBox1);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "Customers";
            Size = new Size(975, 665);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblCustomerID;
        private TextBox txtCustomerID;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPhoneNumber;
        private TextBox textBox1;
        private Label lblEmailAddress;
        private Button btnAddNew;
        private Label lblLicense;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox txtPhoneNumber;
    }
}
