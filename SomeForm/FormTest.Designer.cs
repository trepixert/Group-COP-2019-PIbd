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
            this.button_TestThree = new System.Windows.Forms.Button();
            this.userControlAgliullin = new StudentControlAccounting.UserControlAgliullin();
            this.userControlDmitriev = new StudentControlAccounting.UserControlDmitriev();
            this.userControlMalinin = new StudentControlAccounting.UserControlMalinin();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_TestThree
            // 
            this.button_TestThree.Location = new System.Drawing.Point(30, 165);
            this.button_TestThree.Margin = new System.Windows.Forms.Padding(4);
            this.button_TestThree.Name = "button_TestThree";
            this.button_TestThree.Size = new System.Drawing.Size(149, 28);
            this.button_TestThree.TabIndex = 6;
            this.button_TestThree.Text = "Сменить номер";
            this.button_TestThree.UseVisualStyleBackColor = true;
            this.button_TestThree.Click += new System.EventHandler(this.Button_TestThree_Click);
            // 
            // userControlAgliullin
            // 
            this.userControlAgliullin.IsChecked = false;
            this.userControlAgliullin.Location = new System.Drawing.Point(30, 275);
            this.userControlAgliullin.Name = "userControlAgliullin";
            this.userControlAgliullin.Size = new System.Drawing.Size(272, 66);
            this.userControlAgliullin.TabIndex = 2;
            this.userControlAgliullin.TextBoxValue = null;
            // 
            // userControlDmitriev
            // 
            this.userControlDmitriev.Location = new System.Drawing.Point(344, 14);
            this.userControlDmitriev.Name = "userControlDmitriev";
            this.userControlDmitriev.Size = new System.Drawing.Size(596, 387);
            this.userControlDmitriev.TabIndex = 3;
            this.userControlDmitriev.Load += new System.EventHandler(this.userControlDmitriev_Load);
            // 
            // userControlMalinin
            // 
            this.userControlMalinin.Location = new System.Drawing.Point(14, 14);
            this.userControlMalinin.Margin = new System.Windows.Forms.Padding(5);
            this.userControlMalinin.Name = "userControlMalinin";
            this.userControlMalinin.SelectedIndex = 0;
            this.userControlMalinin.Size = new System.Drawing.Size(272, 131);
            this.userControlMalinin.TabIndex = 5;
            this.userControlMalinin.ListBoxSelectedElementChange += new System.EventHandler(this.userControlMalinin_ListBoxSelectedElementChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonVvod_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControlAgliullin);
            this.Controls.Add(this.userControlDmitriev);
            this.Controls.Add(this.button_TestThree);
            this.Controls.Add(this.userControlMalinin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTest";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private StudentControlAccounting.UserControlMalinin userControlMalinin;
        private System.Windows.Forms.Button button_TestThree;
        private StudentControlAccounting.UserControlDmitriev userControlDmitriev;
        private StudentControlAccounting.UserControlAgliullin userControlAgliullin;
        private System.Windows.Forms.Button button1;
    }
}

