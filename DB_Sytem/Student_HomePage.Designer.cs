namespace DB_Sytem
{
    partial class Student_HomePage
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
            label2 = new Label();
            lbl_studentName = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(39, 40);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Welcome :";
            // 
            // lbl_studentName
            // 
            lbl_studentName.AutoSize = true;
            lbl_studentName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_studentName.ForeColor = Color.Maroon;
            lbl_studentName.Location = new Point(159, 40);
            lbl_studentName.Name = "lbl_studentName";
            lbl_studentName.Size = new Size(0, 25);
            lbl_studentName.TabIndex = 3;
            // 
            // Student_HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_studentName);
            Controls.Add(label2);
            Name = "Student_HomePage";
            Text = "Student_HomePage";
            Load += Student_HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lbl_studentName;
    }
}