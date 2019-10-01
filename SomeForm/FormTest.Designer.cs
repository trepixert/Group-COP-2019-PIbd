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
            this.buttonCombo = new System.Windows.Forms.Button();
            this.userControlAgliullin = new StudentControlAccounting.UserControlAgliullin();
            this.userControlDmitriev = new StudentControlAccounting.UserControlDmitriev();
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
            // buttonCombo
            // 
            this.buttonCombo.Location = new System.Drawing.Point(186, 64);
            this.buttonCombo.Name = "buttonCombo";
            this.buttonCombo.Size = new System.Drawing.Size(113, 23);
            this.buttonCombo.TabIndex = 3;
            this.buttonCombo.Text = "Сменить номер";
            this.buttonCombo.UseVisualStyleBackColor = true;
            this.buttonCombo.Click += new System.EventHandler(this.buttonCombo_Click);
            // 
            // userControlAgliullin
            // 
            this.userControlAgliullin.Location = new System.Drawing.Point(186, 12);
            this.userControlAgliullin.Name = "userControlAgliullin";
            this.userControlAgliullin.SelectedIndex = 0;
            this.userControlAgliullin.Size = new System.Drawing.Size(149, 29);
            this.userControlAgliullin.TabIndex = 2;
            this.userControlAgliullin.ComboBoxSelectedElementChange += new System.EventHandler(this.userControlAgliullin_ComboBoxSelectedElementChange);
            // 
            // userControlDmitriev
            // 
            this.userControlDmitriev.CheckedIndex = null;
            this.userControlDmitriev.Location = new System.Drawing.Point(12, 12);
            this.userControlDmitriev.Name = "userControlDmitriev";
            this.userControlDmitriev.Size = new System.Drawing.Size(123, 99);
            this.userControlDmitriev.TabIndex = 0;
            this.userControlDmitriev.CheckedListBoxSelectedElementChange += new System.EventHandler(this.userControlDmitriev_CheckedListBoxSelectedElementsChange);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 237);
            this.Controls.Add(this.buttonCombo);
            this.Controls.Add(this.userControlAgliullin);
            this.Controls.Add(this.buttonChecked);
            this.Controls.Add(this.userControlDmitriev);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private StudentControlAccounting.UserControlDmitriev userControlDmitriev;
        private System.Windows.Forms.Button buttonChecked;
        private StudentControlAccounting.UserControlAgliullin userControlAgliullin;
        private System.Windows.Forms.Button buttonCombo;
    }
}

