using System.Collections.Generic;
using System.Windows.Forms;

namespace Student
{
    partial class Form1
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
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxBel = new System.Windows.Forms.TextBox();
            this.textBoxForeign = new System.Windows.Forms.TextBox();
            this.textBoxMatem = new System.Windows.Forms.TextBox();
            this.textBoxPhys = new System.Windows.Forms.TextBox();
            this.textBoxChem = new System.Windows.Forms.TextBox();
            this.textBoxBio = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(67, 23);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(63, 20);
            this.textBoxClass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(174, 22);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(33, 20);
            this.textBoxId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(287, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(261, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "БЕЛ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Чужд език";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Математика";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Среден успех";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(284, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Физика";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(284, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Химия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(284, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Биология";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAverage.Location = new System.Drawing.Point(156, 261);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 15);
            this.labelAverage.TabIndex = 13;
            // 
            // textBoxBel
            // 
            this.textBoxBel.Location = new System.Drawing.Point(118, 97);
            this.textBoxBel.Name = "textBoxBel";
            this.textBoxBel.Size = new System.Drawing.Size(38, 20);
            this.textBoxBel.TabIndex = 14;
            // 
            // textBoxForeign
            // 
            this.textBoxForeign.Location = new System.Drawing.Point(118, 144);
            this.textBoxForeign.Name = "textBoxForeign";
            this.textBoxForeign.Size = new System.Drawing.Size(38, 20);
            this.textBoxForeign.TabIndex = 15;
            // 
            // textBoxMatem
            // 
            this.textBoxMatem.Location = new System.Drawing.Point(117, 185);
            this.textBoxMatem.Name = "textBoxMatem";
            this.textBoxMatem.Size = new System.Drawing.Size(38, 20);
            this.textBoxMatem.TabIndex = 16;
            // 
            // textBoxPhys
            // 
            this.textBoxPhys.Location = new System.Drawing.Point(371, 97);
            this.textBoxPhys.Name = "textBoxPhys";
            this.textBoxPhys.Size = new System.Drawing.Size(38, 20);
            this.textBoxPhys.TabIndex = 17;
            // 
            // textBoxChem
            // 
            this.textBoxChem.Location = new System.Drawing.Point(371, 144);
            this.textBoxChem.Name = "textBoxChem";
            this.textBoxChem.Size = new System.Drawing.Size(38, 20);
            this.textBoxChem.TabIndex = 18;
            // 
            // textBoxBio
            // 
            this.textBoxBio.Location = new System.Drawing.Point(371, 190);
            this.textBoxBio.Name = "textBoxBio";
            this.textBoxBio.Size = new System.Drawing.Size(38, 20);
            this.textBoxBio.TabIndex = 19;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(500, 90);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 31);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Изчисти";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(500, 144);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 31);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(500, 204);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(112, 31);
            this.buttonFind.TabIndex = 22;
            this.buttonFind.Text = "Търси";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(371, 261);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(257, 31);
            this.buttonAverage.TabIndex = 23;
            this.buttonAverage.Text = "Пресметни среден";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxBio);
            this.Controls.Add(this.textBoxChem);
            this.Controls.Add(this.textBoxPhys);
            this.Controls.Add(this.textBoxMatem);
            this.Controls.Add(this.textBoxForeign);
            this.Controls.Add(this.textBoxBel);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClass);
            this.Name = "Form1";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   EqualityComparer<Button>.Default.Equals(buttonSave, form.buttonSave);
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.TextBox textBoxBel;
        private System.Windows.Forms.TextBox textBoxForeign;
        private System.Windows.Forms.TextBox textBoxMatem;
        private System.Windows.Forms.TextBox textBoxPhys;
        private System.Windows.Forms.TextBox textBoxChem;
        private System.Windows.Forms.TextBox textBoxBio;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonAverage;
    }
}

