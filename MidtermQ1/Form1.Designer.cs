
namespace MidtermQ1
{
    partial class MidtermQ1
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
            this.labMin = new System.Windows.Forms.Label();
            this.labMax = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.lbRandomNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labMin.Location = new System.Drawing.Point(78, 52);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(59, 26);
            this.labMin.TabIndex = 0;
            this.labMin.Text = "Min: ";
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labMax.Location = new System.Drawing.Point(78, 99);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(65, 26);
            this.labMax.TabIndex = 1;
            this.labMax.Text = "Max: ";
            // 
            // tbMin
            // 
            this.tbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbMin.Location = new System.Drawing.Point(154, 49);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 32);
            this.tbMin.TabIndex = 2;
            // 
            // tbMax
            // 
            this.tbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbMax.Location = new System.Drawing.Point(154, 96);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 32);
            this.tbMax.TabIndex = 3;
            // 
            // lbRandomNum
            // 
            this.lbRandomNum.AutoSize = true;
            this.lbRandomNum.BackColor = System.Drawing.Color.Yellow;
            this.lbRandomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F);
            this.lbRandomNum.ForeColor = System.Drawing.Color.Blue;
            this.lbRandomNum.Location = new System.Drawing.Point(403, 41);
            this.lbRandomNum.Name = "lbRandomNum";
            this.lbRandomNum.Size = new System.Drawing.Size(90, 97);
            this.lbRandomNum.TabIndex = 4;
            this.lbRandomNum.Text = "?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(83, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(237, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "+1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.Location = new System.Drawing.Point(390, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MidtermQ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 341);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRandomNum);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.labMax);
            this.Controls.Add(this.labMin);
            this.Name = "MidtermQ1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MidtermQ1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label labMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label lbRandomNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

