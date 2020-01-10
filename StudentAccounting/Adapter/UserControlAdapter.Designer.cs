namespace Adapter {
    partial class UserControlAdapter {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.controlTextBoxInput1 = new MaxinLib.ControlTextBoxInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 0;
            // 
            // controlTextBoxInput1
            // 
            this.controlTextBoxInput1.IsChecked = false;
            this.controlTextBoxInput1.Location = new System.Drawing.Point(49, 58);
            this.controlTextBoxInput1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTextBoxInput1.Name = "controlTextBoxInput1";
            this.controlTextBoxInput1.Size = new System.Drawing.Size(215, 47);
            this.controlTextBoxInput1.TabIndex = 15;
            this.controlTextBoxInput1.TextBoxValue = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ЗП";
            // 
            // UserControlAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlTextBoxInput1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControlAdapter";
            this.Size = new System.Drawing.Size(336, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private MaxinLib.ControlTextBoxInput controlTextBoxInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
