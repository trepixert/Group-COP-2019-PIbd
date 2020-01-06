namespace FormProject
{
    partial class FormStudents
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.FIO_Field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Scholarship_Field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.controlTreeView1 = new AnikyevLib.ControlTreeView();
            this.userControlAgliullin_Course_Field = new StudentControlAccounting.UserControlAgliullin();
            this.userNonVisualComponenetAgliullin1 = new StudentControlAccounting.userNonVisualComponenetAgliullin(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.wordReport1 = new SharafutdinovaLibNotVisual.WordReport(this.components);
            this.wordDiagram1 = new MaxinLib.WordDiagram(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // FIO_Field
            // 
            this.FIO_Field.Location = new System.Drawing.Point(74, 12);
            this.FIO_Field.Name = "FIO_Field";
            this.FIO_Field.Size = new System.Drawing.Size(149, 20);
            this.FIO_Field.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Курс";
            // 
            // Scholarship_Field
            // 
            this.Scholarship_Field.Location = new System.Drawing.Point(74, 74);
            this.Scholarship_Field.Name = "Scholarship_Field";
            this.Scholarship_Field.Size = new System.Drawing.Size(149, 20);
            this.Scholarship_Field.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стипуха";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(104, 110);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 6;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // controlTreeView1
            // 
            this.controlTreeView1.Location = new System.Drawing.Point(385, 12);
            this.controlTreeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTreeView1.Name = "controlTreeView1";
            this.controlTreeView1.Size = new System.Drawing.Size(369, 274);
            this.controlTreeView1.TabIndex = 7;
            // 
            // userControlAgliullin_Course_Field
            // 
            this.userControlAgliullin_Course_Field.Location = new System.Drawing.Point(74, 38);
            this.userControlAgliullin_Course_Field.Name = "userControlAgliullin_Course_Field";
            this.userControlAgliullin_Course_Field.Size = new System.Drawing.Size(149, 29);
            this.userControlAgliullin_Course_Field.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "BackUp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // wordDiagram1
            // 
            this.wordDiagram1.Data = null;
            this.wordDiagram1.DiagramName = null;
            this.wordDiagram1.Name = null;
            this.wordDiagram1.Value = null;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отчёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Диаграмма";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlTreeView1);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Scholarship_Field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIO_Field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlAgliullin_Course_Field);
            this.Name = "FormStudents";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentControlAccounting.UserControlAgliullin userControlAgliullin_Course_Field;
        private StudentControlAccounting.userNonVisualComponenetAgliullin userNonVisualComponenetAgliullin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIO_Field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Scholarship_Field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_Button;
        private AnikyevLib.ControlTreeView controlTreeView1;
        private System.Windows.Forms.Button button1;
        private SharafutdinovaLibNotVisual.WordReport wordReport1;
        private MaxinLib.WordDiagram wordDiagram1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

