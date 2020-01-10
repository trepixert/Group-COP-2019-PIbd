namespace AbstractFactory {
    partial class UserControlAbstractFactory {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.userControlAgliullin1 = new StudentControlAccounting.UserControlAgliullin();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userControlAgliullin1
            // 
            this.userControlAgliullin1.Location = new System.Drawing.Point(66, 20);
            this.userControlAgliullin1.Name = "userControlAgliullin1";
            this.userControlAgliullin1.Size = new System.Drawing.Size(144, 22);
            this.userControlAgliullin1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(94, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Посетил";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // UserControlAbstractFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userControlAgliullin1);
            this.Name = "UserControlAbstractFactory";
            this.Size = new System.Drawing.Size(230, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StudentControlAccounting.UserControlAgliullin userControlAgliullin1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
