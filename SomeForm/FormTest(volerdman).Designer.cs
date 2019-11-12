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
            this.buttonChecked = new System.Windows.Forms.Button();
            this.userControlAgliullin1 = new StudentControlAccounting.UserControlAgliullin();
            this.userControlMalinin1 = new StudentControlAccounting.UserControlMalinin();
            this.userControlDmitriev = new StudentControlAccounting.UserControlDmitriev();
            this.userNonVisualComponentAgliullin1 = new StudentControlAccounting.userNonVisualComponentAgliullin(this.components);
            this.userNonVisualControlDmitriev1 = new StudentControlAccounting.userNonVisualControlDmitriev(this.components);
            this.userNonVisualControlMalinin1 = new StudentControlAccounting.userNonVisualControlMalinin(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // userControlAgliullin1
            // 
            this.userControlAgliullin1.Location = new System.Drawing.Point(435, 46);
            this.userControlAgliullin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlAgliullin1.Name = "userControlAgliullin1";
            this.userControlAgliullin1.Size = new System.Drawing.Size(182, 168);
            this.userControlAgliullin1.TabIndex = 5;
            // 
            // userControlMalinin1
            // 
            this.userControlMalinin1.Location = new System.Drawing.Point(176, 92);
            this.userControlMalinin1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlMalinin1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.userControlMalinin1.MinValue = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.userControlMalinin1.Name = "userControlMalinin1";
            this.userControlMalinin1.Size = new System.Drawing.Size(177, 22);
            this.userControlMalinin1.TabIndex = 4;
            // 
            // userControlDmitriev
            // 
            this.userControlDmitriev.CheckedIndex = null;
            this.userControlDmitriev.Location = new System.Drawing.Point(12, 35);
            this.userControlDmitriev.Name = "userControlDmitriev";
            this.userControlDmitriev.Size = new System.Drawing.Size(123, 99);
            this.userControlDmitriev.TabIndex = 0;
            // 
            // userNonVisualComponentAgliullin1
            // 
            this.userNonVisualComponentAgliullin1.Data = null;
            this.userNonVisualComponentAgliullin1.DiagramName = null;
            this.userNonVisualComponentAgliullin1.Name = null;
            this.userNonVisualComponentAgliullin1.Value = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.диаграммаToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.backUpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма";
            this.диаграммаToolStripMenuItem.Click += new System.EventHandler(this.диаграммаToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.backUpToolStripMenuItem.Text = "BackUp";
            this.backUpToolStripMenuItem.Click += new System.EventHandler(this.backUpToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentControlAccounting.UserControlDmitriev userControlDmitriev;
        private System.Windows.Forms.Button buttonChecked;
        private StudentControlAccounting.UserControlMalinin userControlMalinin1;
        private StudentControlAccounting.UserControlAgliullin userControlAgliullin1;
        private StudentControlAccounting.userNonVisualComponentAgliullin userNonVisualComponentAgliullin1;
        private StudentControlAccounting.userNonVisualControlDmitriev userNonVisualControlDmitriev1;
        private StudentControlAccounting.userNonVisualControlMalinin userNonVisualControlMalinin1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
    }
}

