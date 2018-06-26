namespace Triangle_point_practise
{
    partial class Author_Form
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
            this.label_practise = new System.Windows.Forms.Label();
            this.label_student = new System.Windows.Forms.Label();
            this.label_525 = new System.Windows.Forms.Label();
            this.label_KHAI = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_theme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_practise
            // 
            this.label_practise.AutoSize = true;
            this.label_practise.Location = new System.Drawing.Point(85, 33);
            this.label_practise.Name = "label_practise";
            this.label_practise.Size = new System.Drawing.Size(117, 13);
            this.label_practise.TabIndex = 0;
            this.label_practise.Text = "Практическая работа";
            // 
            // label_student
            // 
            this.label_student.AutoSize = true;
            this.label_student.Location = new System.Drawing.Point(77, 52);
            this.label_student.Name = "label_student";
            this.label_student.Size = new System.Drawing.Size(133, 13);
            this.label_student.TabIndex = 1;
            this.label_student.Text = "Выпонил студент группы";
            // 
            // label_525
            // 
            this.label_525.AutoSize = true;
            this.label_525.Location = new System.Drawing.Point(72, 71);
            this.label_525.Name = "label_525";
            this.label_525.Size = new System.Drawing.Size(142, 13);
            this.label_525.TabIndex = 2;
            this.label_525.Text = "525-Б, Лукьяненко Кирилл";
            // 
            // label_KHAI
            // 
            this.label_KHAI.AutoSize = true;
            this.label_KHAI.Location = new System.Drawing.Point(110, 239);
            this.label_KHAI.Name = "label_KHAI";
            this.label_KHAI.Size = new System.Drawing.Size(59, 13);
            this.label_KHAI.TabIndex = 3;
            this.label_KHAI.Text = "ХАИ, 2018";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(88, 178);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(107, 32);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_theme
            // 
            this.label_theme.AutoSize = true;
            this.label_theme.Location = new System.Drawing.Point(58, 123);
            this.label_theme.Name = "label_theme";
            this.label_theme.Size = new System.Drawing.Size(167, 13);
            this.label_theme.TabIndex = 5;
            this.label_theme.Text = "Лежит ли точка в треугольнике";
            // 
            // Author_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_theme);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_KHAI);
            this.Controls.Add(this.label_525);
            this.Controls.Add(this.label_student);
            this.Controls.Add(this.label_practise);
            this.Name = "Author_Form";
            this.Text = "Author_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_practise;
        private System.Windows.Forms.Label label_student;
        private System.Windows.Forms.Label label_525;
        private System.Windows.Forms.Label label_KHAI;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_theme;
    }
}