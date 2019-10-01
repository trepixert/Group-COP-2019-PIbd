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
            this.userControlMalinin = new StudentControlAccounting.UserControlMalinin();
            this.SuspendLayout();
            // 
            // button_TestThree
            // 
            this.button_TestThree.Location = new System.Drawing.Point(34, 277);
            this.button_TestThree.Margin = new System.Windows.Forms.Padding(4);
            this.button_TestThree.Name = "button_TestThree";
            this.button_TestThree.Size = new System.Drawing.Size(149, 28);
            this.button_TestThree.TabIndex = 6;
            this.button_TestThree.Text = "Сменить номер";
            this.button_TestThree.UseVisualStyleBackColor = true;
            this.button_TestThree.Click += new System.EventHandler(this.Button_TestThree_Click);
            // 
            // userControlMalinin
            // 
            this.userControlMalinin.Location = new System.Drawing.Point(14, 14);
            this.userControlMalinin.Margin = new System.Windows.Forms.Padding(5);
            this.userControlMalinin.Name = "userControlMalinin";
            this.userControlMalinin.SelectedIndex = 0;
            this.userControlMalinin.Size = new System.Drawing.Size(195, 232);
            this.userControlMalinin.TabIndex = 5;
            this.userControlMalinin.ListBoxSelectedElementChange += new System.EventHandler(this.userControlMalinin_ListBoxSelectedElementChange);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 336);
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
    }
}

