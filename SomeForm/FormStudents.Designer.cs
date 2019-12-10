namespace FormTestProject
{
    partial class FormStudents
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxView1 = new StudentControlAccounting.ListBoxView();
            this.button2 = new System.Windows.Forms.Button();
            this.diagramPDF1 = new StudentControlAccounting.PDFDiagram(this.components);
            this.createDiagramPdf = new System.Windows.Forms.Button();
            this.reportPDF1 = new StudentControlAccounting.PDFReport(this.components);
            this.storeComponent1 = new StudentControlAccounting.UserNonVisualComponentMalinin(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1090, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1090, 105);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 40);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // controlListBoxView1
            // 
            this.listBoxView1.Location = new System.Drawing.Point(36, 41);
            this.listBoxView1.Name = "controlListBoxView1";
            this.listBoxView1.Pattern = null;
            this.listBoxView1.SelectedIndex = -1;
            this.listBoxView1.Size = new System.Drawing.Size(935, 275);
            this.listBoxView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1090, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отчет PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // createDiagramPdf
            // 
            this.createDiagramPdf.Location = new System.Drawing.Point(1090, 248);
            this.createDiagramPdf.Name = "createDiagramPdf";
            this.createDiagramPdf.Size = new System.Drawing.Size(150, 44);
            this.createDiagramPdf.TabIndex = 5;
            this.createDiagramPdf.Text = "Диаграмма PDF";
            this.createDiagramPdf.UseVisualStyleBackColor = true;
            this.createDiagramPdf.Click += new System.EventHandler(this.CreateDiagramPdf_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1090, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Сохранить данные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1090, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Загрузить данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createDiagramPdf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxView1);
            this.Controls.Add(this.button1);
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private StudentControlAccounting.ListBoxView listBoxView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button2;
        private StudentControlAccounting.PDFDiagram diagramPDF1;
        private System.Windows.Forms.Button createDiagramPdf;
        private StudentControlAccounting.PDFReport reportPDF1;
        private StudentControlAccounting.UserNonVisualComponentMalinin storeComponent1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}