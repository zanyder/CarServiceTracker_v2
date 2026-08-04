namespace CarServiceTracker_v2
{
    partial class MainKanban
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
            listEstimates = new ListBox();
            listInProgress = new ListBox();
            listCompleted = new ListBox();
            lblEstimates = new Label();
            lblInProgress = new Label();
            lblCompleted = new Label();
            lblNewEstimate = new Button();
            navPanel = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // listEstimates
            // 
            listEstimates.FormattingEnabled = true;
            listEstimates.Location = new Point(96, 128);
            listEstimates.Name = "listEstimates";
            listEstimates.Size = new Size(215, 424);
            listEstimates.TabIndex = 0;
            // 
            // listInProgress
            // 
            listInProgress.FormattingEnabled = true;
            listInProgress.Location = new Point(371, 128);
            listInProgress.Name = "listInProgress";
            listInProgress.Size = new Size(215, 424);
            listInProgress.TabIndex = 1;
            // 
            // listCompleted
            // 
            listCompleted.FormattingEnabled = true;
            listCompleted.Location = new Point(643, 128);
            listCompleted.Name = "listCompleted";
            listCompleted.Size = new Size(215, 424);
            listCompleted.TabIndex = 2;
            // 
            // lblEstimates
            // 
            lblEstimates.AutoSize = true;
            lblEstimates.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstimates.Location = new Point(96, 94);
            lblEstimates.Name = "lblEstimates";
            lblEstimates.Size = new Size(112, 31);
            lblEstimates.TabIndex = 3;
            lblEstimates.Text = "Estimates";
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInProgress.Location = new Point(371, 94);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(127, 31);
            lblInProgress.TabIndex = 4;
            lblInProgress.Text = "In Progress";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompleted.Location = new Point(643, 94);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(127, 31);
            lblCompleted.TabIndex = 5;
            lblCompleted.Text = "Completed";
            // 
            // lblNewEstimate
            // 
            lblNewEstimate.Location = new Point(400, 570);
            lblNewEstimate.Name = "lblNewEstimate";
            lblNewEstimate.Size = new Size(141, 38);
            lblNewEstimate.TabIndex = 6;
            lblNewEstimate.Text = "New Estimate";
            lblNewEstimate.UseVisualStyleBackColor = true;
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.Gray;
            navPanel.Controls.Add(button4);
            navPanel.Controls.Add(button3);
            navPanel.Controls.Add(button2);
            navPanel.Controls.Add(button1);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(957, 39);
            navPanel.TabIndex = 8;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 0;
            button1.Text = "Workflow";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(94, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 1;
            button2.Text = "Customers";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(188, 0);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 2;
            button3.Text = "Services";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(282, 0);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 3;
            button4.Text = "Invoices";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // MainKanban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 618);
            Controls.Add(navPanel);
            Controls.Add(lblNewEstimate);
            Controls.Add(lblCompleted);
            Controls.Add(lblInProgress);
            Controls.Add(lblEstimates);
            Controls.Add(listCompleted);
            Controls.Add(listInProgress);
            Controls.Add(listEstimates);
            Name = "MainKanban";
            Text = "MainKanban";
            navPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEstimates;
        private ListBox listInProgress;
        private ListBox listCompleted;
        private Label lblEstimates;
        private Label lblInProgress;
        private Label lblCompleted;
        private Button lblNewEstimate;
        private Panel navPanel;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}