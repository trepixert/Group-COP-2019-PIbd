using StudentControlAccounting;

namespace FormTestProject
{
    partial class FormTest2
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonJson = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.wordReport1 = new StudentControlAccounting.UserNonVisualComponentDmitriev(this.components);
            this.componentExportDiagram1 = new StudentControlAccounting.UserNonVisualComponentAgliullin(this.components);
            this.jsonStoreComponent = new StudentControlAccounting.UserNonVisualComponentMalinin(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "SaveWordReport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "CreateExcelDiagram";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonJson
            // 
            this.buttonJson.Location = new System.Drawing.Point(136, 201);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(202, 47);
            this.buttonJson.TabIndex = 4;
            this.buttonJson.Text = "SaveJSON";
            this.buttonJson.UseVisualStyleBackColor = true;
            this.buttonJson.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "LoadJSON";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonJson);
            this.Name = "FormTest2";
            this.Text = "FormTest2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private UserNonVisualComponentDmitriev wordReport1;
        private StudentControlAccounting.UserNonVisualComponentAgliullin componentExportDiagram1;
        private System.Windows.Forms.Button button2;
        private StudentControlAccounting.UserNonVisualComponentMalinin jsonStoreComponent;
        private System.Windows.Forms.Button buttonJson;
        private System.Windows.Forms.Button button4;
    }
}