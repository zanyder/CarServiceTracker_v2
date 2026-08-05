namespace CarServiceTracker_v2
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
            navPanel = new Panel();
            btnInvoices = new Button();
            btnServices = new Button();
            btnCustomers = new Button();
            btnWorkflow = new Button();
            mainDisplayPanel = new Panel();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.Gray;
            navPanel.Controls.Add(btnInvoices);
            navPanel.Controls.Add(btnServices);
            navPanel.Controls.Add(btnCustomers);
            navPanel.Controls.Add(btnWorkflow);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(957, 39);
            navPanel.TabIndex = 8;
            // 
            // btnInvoices
            // 
            btnInvoices.Dock = DockStyle.Left;
            btnInvoices.FlatAppearance.BorderSize = 0;
            btnInvoices.FlatStyle = FlatStyle.Flat;
            btnInvoices.Location = new Point(669, 0);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(227, 39);
            btnInvoices.TabIndex = 3;
            btnInvoices.Text = "Invoices";
            btnInvoices.TextAlign = ContentAlignment.TopCenter;
            btnInvoices.UseVisualStyleBackColor = true;
            btnInvoices.Click += this.btnInvoices_Click;
            // 
            // btnServices
            // 
            btnServices.Dock = DockStyle.Left;
            btnServices.FlatAppearance.BorderSize = 0;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Location = new Point(440, 0);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(229, 39);
            btnServices.TabIndex = 2;
            btnServices.Text = "Services";
            btnServices.TextAlign = ContentAlignment.TopCenter;
            btnServices.UseVisualStyleBackColor = true;
            btnServices.Click += btnServices_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Left;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Location = new Point(200, 0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(240, 39);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.TopCenter;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnWorkflow
            // 
            btnWorkflow.Dock = DockStyle.Left;
            btnWorkflow.FlatAppearance.BorderSize = 0;
            btnWorkflow.FlatStyle = FlatStyle.Flat;
            btnWorkflow.Location = new Point(0, 0);
            btnWorkflow.Name = "btnWorkflow";
            btnWorkflow.Size = new Size(200, 39);
            btnWorkflow.TabIndex = 0;
            btnWorkflow.Text = "Workflow";
            btnWorkflow.TextAlign = ContentAlignment.TopCenter;
            btnWorkflow.UseVisualStyleBackColor = true;
            btnWorkflow.Click += btnWorkflow_Click;
            // 
            // mainDisplayPanel
            // 
            mainDisplayPanel.Dock = DockStyle.Fill;
            mainDisplayPanel.Location = new Point(0, 0);
            mainDisplayPanel.Name = "mainDisplayPanel";
            mainDisplayPanel.Size = new Size(957, 618);
            mainDisplayPanel.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 618);
            Controls.Add(navPanel);
            Controls.Add(mainDisplayPanel);
            Name = "MainForm";
            Text = "Zany Service Tracker";
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel navPanel;
        private Button btnServices;
        private Button btnCustomers;
        private Button btnWorkflow;
        private Button btnInvoices;
        private Panel mainDisplayPanel;
    }
}