namespace FormTestProject
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTimePicker1 = new StudentControlAccounting.DataTimePicker();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.checkedListBox1 = new StudentControlAccounting.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dataTimePicker1
            // 
            this.dataTimePicker1.Location = new System.Drawing.Point(50, 347);
            this.dataTimePicker1.MaxDate = "31.12.9998";
            this.dataTimePicker1.MinValue = "01.01.1753";
            this.dataTimePicker1.Name = "dataTimePicker1";
            this.dataTimePicker1.Size = new System.Drawing.Size(233, 27);
            this.dataTimePicker1.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(587, 93);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(158, 42);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckedIndeces = null;
            this.checkedListBox1.Location = new System.Drawing.Point(21, 125);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(357, 175);
            this.checkedListBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 22);
            this.textBox1.TabIndex = 3;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataTimePicker1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentControlAccounting.CheckedListBox checkedListBox1;
        private StudentControlAccounting.DataTimePicker dataTimePicker1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBox1;
    }
}