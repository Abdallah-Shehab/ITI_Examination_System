namespace DB_Sytem
{
    partial class Exam_Creation
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
            comboBox1 = new ComboBox();
            dt_date = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_create = new Button();
            dt_time = new DateTimePicker();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 29);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Subject";
            // 
            // dt_date
            // 
            dt_date.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_date.Format = DateTimePickerFormat.Short;
            dt_date.ImeMode = ImeMode.Katakana;
            dt_date.Location = new Point(114, 42);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(200, 26);
            dt_date.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(129, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(129, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(37, 84);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 10;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(60, 122);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 11;
            label3.Text = "Grade";
            // 
            // btn_create
            // 
            btn_create.Location = new Point(113, 298);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(116, 42);
            btn_create.TabIndex = 12;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // dt_time
            // 
            dt_time.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_time.Format = DateTimePickerFormat.Time;
            dt_time.Location = new Point(114, 77);
            dt_time.Name = "dt_time";
            dt_time.Size = new Size(200, 26);
            dt_time.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dt_time);
            groupBox1.Controls.Add(dt_date);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 119);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exam Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 46);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 14;
            label1.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 77);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 15;
            label4.Text = "Time";
            // 
            // Exam_Creation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 352);
            Controls.Add(groupBox1);
            Controls.Add(btn_create);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Exam_Creation";
            Text = "Exam_Creation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DateTimePicker dt_date;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button btn_create;
        private DateTimePicker dt_time;
        private GroupBox groupBox1;
        private Label label4;
        private Label label1;
    }
}