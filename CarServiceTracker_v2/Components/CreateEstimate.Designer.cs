namespace CarServiceTracker_v2.Components
{
    partial class CreateEstimate
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
            lblCreateEstimate = new Label();
            SuspendLayout();
            // 
            // lblCreateEstimate
            // 
            lblCreateEstimate.AutoSize = true;
            lblCreateEstimate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateEstimate.Location = new Point(357, 90);
            lblCreateEstimate.Name = "lblCreateEstimate";
            lblCreateEstimate.Size = new Size(174, 31);
            lblCreateEstimate.TabIndex = 0;
            lblCreateEstimate.Text = "Create Estimate";
            // 
            // CreateEstimate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCreateEstimate);
            Name = "CreateEstimate";
            Size = new Size(975, 665);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateEstimate;
    }
}
