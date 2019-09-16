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
            this.ButtonTest = new System.Windows.Forms.Button();
            this.userControlAgliullin = new StudentControlAccounting.UserControlAgliullin();
            this.userControlDmitriev = new StudentControlAccounting.UserControlDmitriev();
            this.button_TestTwo = new System.Windows.Forms.Button();
            this.userControlMalinin = new StudentControlAccounting.UserControlMalinin();
            this.button_TestThree = new System.Windows.Forms.Button();
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
            // userControlAgliullin
            // 
            this.userControlAgliullin.Location = new System.Drawing.Point(12, 24);
            this.userControlAgliullin.Name = "userControlAgliullin";
            this.userControlAgliullin.Size = new System.Drawing.Size(149, 72);
            this.userControlAgliullin.TabIndex = 0;
            // 
            // userControlDmitriev
            // 
            this.userControlDmitriev.Location = new System.Drawing.Point(189, 12);
            this.userControlDmitriev.Name = "userControlDmitriev";
            this.userControlDmitriev.Size = new System.Drawing.Size(240, 268);
            this.userControlDmitriev.TabIndex = 3;
            // 
            // button_TestTwo
            // 
            this.button_TestTwo.Location = new System.Drawing.Point(276, 301);
            this.button_TestTwo.Name = "button_TestTwo";
            this.button_TestTwo.Size = new System.Drawing.Size(75, 23);
            this.button_TestTwo.TabIndex = 4;
            this.button_TestTwo.Text = "ClickTwo";
            this.button_TestTwo.UseVisualStyleBackColor = true;
            this.button_TestTwo.Click += new System.EventHandler(this.Button_TestTwo_Click);
            // 
            // userControlMalinin
            // 
            this.userControlMalinin.Location = new System.Drawing.Point(559, 12);
            this.userControlMalinin.Name = "userControlMalinin";
            this.userControlMalinin.Size = new System.Drawing.Size(150, 150);
            this.userControlMalinin.TabIndex = 5;
            // 
            // button_TestThree
            // 
            this.button_TestThree.Location = new System.Drawing.Point(591, 169);
            this.button_TestThree.Name = "button_TestThree";
            this.button_TestThree.Size = new System.Drawing.Size(75, 23);
            this.button_TestThree.TabIndex = 6;
            this.button_TestThree.Text = "Click Three";
            this.button_TestThree.UseVisualStyleBackColor = true;
            this.button_TestThree.Click += new System.EventHandler(this.Button_TestThree_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

