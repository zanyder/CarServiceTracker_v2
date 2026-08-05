namespace CarServiceTracker_v2
{
    partial class WorkflowView
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
            listEstimates = new ListBox();
            btnNewEstimate = new Button();
            listInProgress = new ListBox();
            lblCompleted = new Label();
            listCompleted = new ListBox();
            lblInProgress = new Label();
            lblEstimates = new Label();
            btnRefresh = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listEstimates
            // 
            listEstimates.FormattingEnabled = true;
            listEstimates.Location = new Point(78, 139);
            listEstimates.Name = "listEstimates";
            listEstimates.Size = new Size(215, 424);
            listEstimates.TabIndex = 7;
            // 
            // btnNewEstimate
            // 
            btnNewEstimate.Location = new Point(83, 35);
            btnNewEstimate.Name = "btnNewEstimate";
            btnNewEstimate.Size = new Size(141, 38);
            btnNewEstimate.TabIndex = 13;
            btnNewEstimate.Text = "New Estimate";
            btnNewEstimate.UseVisualStyleBackColor = true;
            // 
            // listInProgress
            // 
            listInProgress.FormattingEnabled = true;
            listInProgress.Location = new Point(358, 139);
            listInProgress.Name = "listInProgress";
            listInProgress.Size = new Size(215, 424);
            listInProgress.TabIndex = 8;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompleted.Location = new Point(630, 105);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(127, 31);
            lblCompleted.TabIndex = 12;
            lblCompleted.Text = "Completed";
            // 
            // listCompleted
            // 
            listCompleted.FormattingEnabled = true;
            listCompleted.Location = new Point(630, 139);
            listCompleted.Name = "listCompleted";
            listCompleted.Size = new Size(215, 424);
            listCompleted.TabIndex = 9;
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInProgress.Location = new Point(358, 105);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(127, 31);
            lblInProgress.TabIndex = 11;
            lblInProgress.Text = "In Progress";
            // 
            // lblEstimates
            // 
            lblEstimates.AutoSize = true;
            lblEstimates.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstimates.Location = new Point(83, 105);
            lblEstimates.Name = "lblEstimates";
            lblEstimates.Size = new Size(112, 31);
            lblEstimates.TabIndex = 10;
            lblEstimates.Text = "Estimates";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(406, 594);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 38);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(664, 65);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // WorkflowView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(btnRefresh);
            Controls.Add(listEstimates);
            Controls.Add(btnNewEstimate);
            Controls.Add(listInProgress);
            Controls.Add(lblCompleted);
            Controls.Add(listCompleted);
            Controls.Add(lblInProgress);
            Controls.Add(lblEstimates);
            Name = "WorkflowView";
            Size = new Size(975, 665);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEstimates;
        private Button btnNewEstimate;
        private ListBox listInProgress;
        private Label lblCompleted;
        private ListBox listCompleted;
        private Label lblInProgress;
        private Label lblEstimates;
        private Button btnRefresh;
        private Button button1;
    }
}
