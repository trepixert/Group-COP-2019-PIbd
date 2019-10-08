namespace FormTestProject
{
    partial class FormTest
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
            this.ButtonTest = new System.Windows.Forms.Button();
            this.button_TestTwo = new System.Windows.Forms.Button();
            this.button_TestThree = new System.Windows.Forms.Button();
            this.test_button_backup = new System.Windows.Forms.Button();
            this.ReportToExcel_Button = new System.Windows.Forms.Button();
            this.PdfReport_Button = new System.Windows.Forms.Button();
            this.userControlMalinin = new StudentControlAccounting.UserControlMalinin();
            this.userControlDmitriev = new StudentControlAccounting.UserControlDmitriev();
            this.userControlAgliullin = new StudentControlAccounting.UserControlAgliullin();
            this.userNonVisualComponenetAgliullin = new StudentControlAccounting.userNonVisualComponenetAgliullin(this.components);
            this.userNonVisualComponentDmitriev1 = new StudentControlAccounting.userNonVisualComponentDmitriev(this.components);
            this.userNonVisualComponenetAgliullin1 = new StudentControlAccounting.userNonVisualComponenetAgliullin(this.components);
            this.userNonVisualComponentMalinin1 = new StudentControlAccounting.userNonVisualComponentMalinin(this.components);
            this.SuspendLayout();
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(35, 63);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(75, 23);
            this.ButtonTest.TabIndex = 2;
            this.ButtonTest.Text = "Click";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // button_TestTwo
            // 
            this.button_TestTwo.Location = new System.Drawing.Point(247, 56);
            this.button_TestTwo.Name = "button_TestTwo";
            this.button_TestTwo.Size = new System.Drawing.Size(75, 23);
            this.button_TestTwo.TabIndex = 4;
            this.button_TestTwo.Text = "ClickTwo";
            this.button_TestTwo.UseVisualStyleBackColor = true;
            this.button_TestTwo.Click += new System.EventHandler(this.Button_TestTwo_Click);
            // 
            // button_TestThree
            // 
            this.button_TestThree.Location = new System.Drawing.Point(462, 168);
            this.button_TestThree.Name = "button_TestThree";
            this.button_TestThree.Size = new System.Drawing.Size(75, 23);
            this.button_TestThree.TabIndex = 6;
            this.button_TestThree.Text = "Click Three";
            this.button_TestThree.UseVisualStyleBackColor = true;
            this.button_TestThree.Click += new System.EventHandler(this.Button_TestThree_Click);
            // 
            // test_button_backup
            // 
            this.test_button_backup.Location = new System.Drawing.Point(35, 168);
            this.test_button_backup.Name = "test_button_backup";
            this.test_button_backup.Size = new System.Drawing.Size(75, 23);
            this.test_button_backup.TabIndex = 7;
            this.test_button_backup.Text = "TEST";
            this.test_button_backup.UseVisualStyleBackColor = true;
            this.test_button_backup.Click += new System.EventHandler(this.Test_button_backup_Click);
            // 
            // ReportToExcel_Button
            // 
            this.ReportToExcel_Button.Location = new System.Drawing.Point(116, 168);
            this.ReportToExcel_Button.Name = "ReportToExcel_Button";
            this.ReportToExcel_Button.Size = new System.Drawing.Size(75, 23);
            this.ReportToExcel_Button.TabIndex = 8;
            this.ReportToExcel_Button.Text = "TEST №2";
            this.ReportToExcel_Button.UseVisualStyleBackColor = true;
            this.ReportToExcel_Button.Click += new System.EventHandler(this.ReportToExcel_Button_Click);
            // 
            // PdfReport_Button
            // 
            this.PdfReport_Button.Location = new System.Drawing.Point(197, 168);
            this.PdfReport_Button.Name = "PdfReport_Button";
            this.PdfReport_Button.Size = new System.Drawing.Size(75, 23);
            this.PdfReport_Button.TabIndex = 9;
            this.PdfReport_Button.Text = "TEST №3";
            this.PdfReport_Button.UseVisualStyleBackColor = true;
            this.PdfReport_Button.Click += new System.EventHandler(this.PdfReport_Button_Click);
            // 
            // userControlMalinin
            // 
            this.userControlMalinin.FieldType = null;
            this.userControlMalinin.Location = new System.Drawing.Point(412, 12);
            this.userControlMalinin.Name = "userControlMalinin";
            this.userControlMalinin.Size = new System.Drawing.Size(150, 150);
            this.userControlMalinin.TabIndex = 5;
            // 
            // userControlDmitriev
            // 
            this.userControlDmitriev.AcceptColor = System.Drawing.Color.Green;
            this.userControlDmitriev.DangerColor = System.Drawing.Color.Red;
            this.userControlDmitriev.Location = new System.Drawing.Point(212, 24);
            this.userControlDmitriev.Name = "userControlDmitriev";
            this.userControlDmitriev.Size = new System.Drawing.Size(147, 26);
            this.userControlDmitriev.TabIndex = 3;
            // 
            // userControlAgliullin
            // 
            this.userControlAgliullin.Location = new System.Drawing.Point(12, 24);
            this.userControlAgliullin.Name = "userControlAgliullin";
            this.userControlAgliullin.Size = new System.Drawing.Size(149, 72);
            this.userControlAgliullin.TabIndex = 0;
            // 
            // userNonVisualComponentMalinin1
            // 
            this.userNonVisualComponentMalinin1.FieldType = "Name Surname Date";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.PdfReport_Button);
            this.Controls.Add(this.ReportToExcel_Button);
            this.Controls.Add(this.test_button_backup);
            this.Controls.Add(this.button_TestThree);
            this.Controls.Add(this.userControlMalinin);
            this.Controls.Add(this.button_TestTwo);
            this.Controls.Add(this.userControlDmitriev);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.userControlAgliullin);
            this.Name = "FormTest";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private StudentControlAccounting.UserControlAgliullin userControlAgliullin;
        private System.Windows.Forms.Button ButtonTest;
        private StudentControlAccounting.UserControlDmitriev userControlDmitriev;
        private System.Windows.Forms.Button button_TestTwo;
        private StudentControlAccounting.UserControlMalinin userControlMalinin;
        private System.Windows.Forms.Button button_TestThree;
        private StudentControlAccounting.userNonVisualComponenetAgliullin userNonVisualComponenetAgliullin;
        private System.Windows.Forms.Button test_button_backup;
        private System.Windows.Forms.Button ReportToExcel_Button;
        private StudentControlAccounting.userNonVisualComponentDmitriev userNonVisualComponentDmitriev1;
        private StudentControlAccounting.userNonVisualComponenetAgliullin userNonVisualComponenetAgliullin1;
        private System.Windows.Forms.Button PdfReport_Button;
        private StudentControlAccounting.userNonVisualComponentMalinin userNonVisualComponentMalinin1;
    }
}

