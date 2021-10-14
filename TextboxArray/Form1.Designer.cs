
namespace TextboxArray
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelZeros = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.textBox00 = new System.Windows.Forms.TextBox();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter or update one integer a time in any box below";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnter.Location = new System.Drawing.Point(481, 123);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 26);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(481, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 26);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(78, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text boxes with a number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(140, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sum of all boxes: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(31, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Average of boxes with a number: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(145, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max of all boxes: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(149, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Min of all boxes: ";
            // 
            // labelZeros
            // 
            this.labelZeros.AutoSize = true;
            this.labelZeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeros.Location = new System.Drawing.Point(292, 279);
            this.labelZeros.Name = "labelZeros";
            this.labelZeros.Size = new System.Drawing.Size(21, 24);
            this.labelZeros.TabIndex = 8;
            this.labelZeros.Text = "0";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.Location = new System.Drawing.Point(292, 302);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(21, 24);
            this.labelSum.TabIndex = 9;
            this.labelSum.Text = "?";
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvg.Location = new System.Drawing.Point(292, 325);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(21, 24);
            this.labelAvg.TabIndex = 10;
            this.labelAvg.Text = "?";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(292, 349);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(21, 24);
            this.labelMax.TabIndex = 11;
            this.labelMax.Text = "?";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(292, 373);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(21, 24);
            this.labelMin.TabIndex = 12;
            this.labelMin.Text = "?";
            // 
            // textBox00
            // 
            this.textBox00.BackColor = System.Drawing.Color.Cyan;
            this.textBox00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox00.Location = new System.Drawing.Point(56, 123);
            this.textBox00.Name = "textBox00";
            this.textBox00.Size = new System.Drawing.Size(100, 26);
            this.textBox00.TabIndex = 13;
            // 
            // textBox01
            // 
            this.textBox01.BackColor = System.Drawing.Color.Cyan;
            this.textBox01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox01.Location = new System.Drawing.Point(173, 123);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(100, 26);
            this.textBox01.TabIndex = 14;
            // 
            // textBox02
            // 
            this.textBox02.BackColor = System.Drawing.Color.Cyan;
            this.textBox02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox02.Location = new System.Drawing.Point(295, 123);
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(100, 26);
            this.textBox02.TabIndex = 15;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Cyan;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox10.Location = new System.Drawing.Point(57, 162);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 26);
            this.textBox10.TabIndex = 16;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Cyan;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox11.Location = new System.Drawing.Point(174, 162);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 26);
            this.textBox11.TabIndex = 17;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Cyan;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox12.Location = new System.Drawing.Point(296, 162);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 26);
            this.textBox12.TabIndex = 18;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.Cyan;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox22.Location = new System.Drawing.Point(296, 200);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 26);
            this.textBox22.TabIndex = 21;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.Cyan;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox21.Location = new System.Drawing.Point(174, 200);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 26);
            this.textBox21.TabIndex = 20;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.Cyan;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox20.Location = new System.Drawing.Point(57, 200);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 26);
            this.textBox20.TabIndex = 19;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 412);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox02);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.textBox00);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelZeros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment 5 (ch08)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelZeros;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBox00;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
    }
}

