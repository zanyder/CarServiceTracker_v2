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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            lblEstimates = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(68, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(215, 424);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(343, 126);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(215, 424);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(615, 126);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(215, 424);
            listBox3.TabIndex = 2;
            // 
            // lblEstimates
            // 
            lblEstimates.AutoSize = true;
            lblEstimates.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstimates.Location = new Point(68, 92);
            lblEstimates.Name = "lblEstimates";
            lblEstimates.Size = new Size(112, 31);
            lblEstimates.TabIndex = 3;
            lblEstimates.Text = "Estimates";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(422, 294);
            label1.Name = "label1";
            label1.Size = new Size(112, 31);
            label1.TabIndex = 4;
            label1.Text = "Estimates";
            // 
            // MainKanban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 618);
            Controls.Add(label1);
            Controls.Add(lblEstimates);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "MainKanban";
            Text = "MainKanban";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label lblEstimates;
        private Label label1;
    }
}