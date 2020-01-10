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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.wordReport1 = new SharafutdinovaLibNotVisual.WordReport();
            this.wordDiagram1 = new MaxinLib.WordDiagram();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.controlTreeView1 = new AnikyevLib.ControlTreeView();
            this.fio_field = new System.Windows.Forms.TextBox();
            this.controlTextBoxInput1 = new MaxinLib.ControlTextBoxInput();
            this.controlTreeView2 = new AnikyevLib.ControlTreeView();
            this.userControlAbstractFactory1 = new AbstractFactory.UserControlAbstractFactory();
            this.userControlAgliullin_Course_Field = new StudentControlAccounting.UserControlAgliullin();
            this.userNonVisualComponenetAgliullin1 = new StudentControlAccounting.userNonVisualComponenetAgliullin();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Курс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стипуха";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(93, 154);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 6;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
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
            this.button2.Location = new System.Drawing.Point(39, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отчёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Диаграмма";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Plugin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 212);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
            // 
            // controlTreeView1
            // 
            this.controlTreeView1.Location = new System.Drawing.Point(385, 12);
            this.controlTreeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTreeView1.Name = "controlTreeView1";
            this.controlTreeView1.Size = new System.Drawing.Size(369, 274);
            this.controlTreeView1.TabIndex = 7;
            // 
            // fio_field
            // 
            this.fio_field.Location = new System.Drawing.Point(74, 13);
            this.fio_field.Name = "fio_field";
            this.fio_field.Size = new System.Drawing.Size(149, 20);
            this.fio_field.TabIndex = 13;
            // 
            // controlTextBoxInput1
            // 
            this.controlTextBoxInput1.IsChecked = false;
            this.controlTextBoxInput1.Location = new System.Drawing.Point(73, 86);
            this.controlTextBoxInput1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTextBoxInput1.Name = "controlTextBoxInput1";
            this.controlTextBoxInput1.Size = new System.Drawing.Size(215, 47);
            this.controlTextBoxInput1.TabIndex = 14;
            this.controlTextBoxInput1.TextBoxValue = null;
            // 
            // controlTreeView2
            // 
            this.controlTreeView2.Location = new System.Drawing.Point(385, 337);
            this.controlTreeView2.Name = "controlTreeView2";
            this.controlTreeView2.Size = new System.Drawing.Size(369, 204);
            this.controlTreeView2.TabIndex = 16;
            // 
            // userControlAbstractFactory1
            // 
            this.userControlAbstractFactory1.Location = new System.Drawing.Point(27, 337);
            this.userControlAbstractFactory1.Name = "userControlAbstractFactory1";
            this.userControlAbstractFactory1.Size = new System.Drawing.Size(230, 98);
            this.userControlAbstractFactory1.TabIndex = 15;
            // 
            // userControlAgliullin_Course_Field
            // 
            this.userControlAgliullin_Course_Field.Location = new System.Drawing.Point(74, 44);
            this.userControlAgliullin_Course_Field.Name = "userControlAgliullin_Course_Field";
            this.userControlAgliullin_Course_Field.Size = new System.Drawing.Size(149, 29);
            this.userControlAgliullin_Course_Field.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(122, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 599);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.controlTreeView2);
            this.Controls.Add(this.userControlAbstractFactory1);
            this.Controls.Add(this.controlTextBoxInput1);
            this.Controls.Add(this.fio_field);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlTreeView1);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_Button;
        private AnikyevLib.ControlTreeView controlTreeView1;
        private System.Windows.Forms.Button button1;
        private SharafutdinovaLibNotVisual.WordReport wordReport1;
        private MaxinLib.WordDiagram wordDiagram1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox fio_field;
        private MaxinLib.ControlTextBoxInput controlTextBoxInput1;
        private AbstractFactory.UserControlAbstractFactory userControlAbstractFactory1;
        private System.Windows.Forms.Button button5;
        private AnikyevLib.ControlTreeView controlTreeView2;
    }
}

