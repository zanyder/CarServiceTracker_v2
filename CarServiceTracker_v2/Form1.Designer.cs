namespace CarServiceTracker_v2
{
    partial class Form1
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
            lstServices = new ListBox();
            cbxCustomerSelect = new ComboBox();
            cbxVehicleSelect = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // lstServices
            // 
            lstServices.FormattingEnabled = true;
            lstServices.Location = new Point(142, 230);
            lstServices.Name = "lstServices";
            lstServices.Size = new Size(553, 264);
            lstServices.TabIndex = 0;
            lstServices.SelectedIndexChanged += lstServices_SelectedIndexChanged;
            // 
            // cbxCustomerSelect
            // 
            cbxCustomerSelect.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxCustomerSelect.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxCustomerSelect.FormattingEnabled = true;
            cbxCustomerSelect.Items.AddRange(new object[] { "Alys", "Mark", "Zuckerburd" });
            cbxCustomerSelect.Location = new Point(6, 46);
            cbxCustomerSelect.Name = "cbxCustomerSelect";
            cbxCustomerSelect.Size = new Size(231, 28);
            cbxCustomerSelect.TabIndex = 1;
            cbxCustomerSelect.Text = "Select Customer";
            cbxCustomerSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbxVehicleSelect
            // 
            cbxVehicleSelect.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxVehicleSelect.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxVehicleSelect.FormattingEnabled = true;
            cbxVehicleSelect.Items.AddRange(new object[] { "2018 Honda Civic SE", "2014 Toyota Corolla S", "2015 Volvo XC-60" });
            cbxVehicleSelect.Location = new Point(453, 70);
            cbxVehicleSelect.Name = "cbxVehicleSelect";
            cbxVehicleSelect.Size = new Size(242, 28);
            cbxVehicleSelect.TabIndex = 2;
            cbxVehicleSelect.Text = "Select Vehicle";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(189, 136);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(716, 472);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbxCustomerSelect);
            tabPage1.Controls.Add(lstServices);
            tabPage1.Controls.Add(cbxVehicleSelect);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(708, 439);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 590);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 618);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstServices;
        private ComboBox cbxCustomerSelect;
        private ComboBox cbxVehicleSelect;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
