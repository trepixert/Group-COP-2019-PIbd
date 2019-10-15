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
            this.buttonChecked = new System.Windows.Forms.Button();
            this.userControlMalinin1 = new StudentControlAccounting.UserControlMalinin();
            this.userControlDmitriev = new StudentControlAccounting.UserControlDmitriev();
            this.userControlAgliullin1 = new StudentControlAccounting.UserControlAgliullin();
            this.SuspendLayout();
            // 
            // buttonChecked
            // 
            this.buttonChecked.Location = new System.Drawing.Point(12, 151);
            this.buttonChecked.Name = "buttonChecked";
            this.buttonChecked.Size = new System.Drawing.Size(118, 26);
            this.buttonChecked.TabIndex = 1;
            this.buttonChecked.Text = "Сменить номер";
            this.buttonChecked.UseVisualStyleBackColor = true;
            this.buttonChecked.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // userControlMalinin1
            // 
            this.userControlMalinin1.Location = new System.Drawing.Point(176, 72);
            this.userControlMalinin1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlMalinin1.MaxDate = "31.12.9998";
            this.userControlMalinin1.MinValue = "01.01.1753";
            this.userControlMalinin1.Name = "userControlMalinin1";
            this.userControlMalinin1.Size = new System.Drawing.Size(177, 22);
            this.userControlMalinin1.TabIndex = 4;
            // 
            // userControlDmitriev
            // 
            this.userControlDmitriev.CheckedIndex = null;
            this.userControlDmitriev.Location = new System.Drawing.Point(12, 12);
            this.userControlDmitriev.Name = "userControlDmitriev";
            this.userControlDmitriev.Size = new System.Drawing.Size(123, 99);
            this.userControlDmitriev.TabIndex = 0;
            // 
            // userControlAgliullin1
            // 
            this.userControlAgliullin1.Location = new System.Drawing.Point(438, 24);
            this.userControlAgliullin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlAgliullin1.Name = "userControlAgliullin1";
            this.userControlAgliullin1.Size = new System.Drawing.Size(182, 168);
            this.userControlAgliullin1.TabIndex = 5;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 281);
            this.Controls.Add(this.userControlAgliullin1);
            this.Controls.Add(this.userControlMalinin1);
            this.Controls.Add(this.buttonChecked);
            this.Controls.Add(this.userControlDmitriev);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private StudentControlAccounting.UserControlDmitriev userControlDmitriev;
        private System.Windows.Forms.Button buttonChecked;
        private StudentControlAccounting.UserControlMalinin userControlMalinin1;
        private StudentControlAccounting.UserControlAgliullin userControlAgliullin1;
    }
}

