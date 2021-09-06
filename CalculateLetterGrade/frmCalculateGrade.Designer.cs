
namespace CalculateLetterGrade
{
    partial class frmCalculateGrade
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNumbGrad = new System.Windows.Forms.Label();
            this.txtLetGrad = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(75, 184);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 34);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(240, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNumbGrad
            // 
            this.txtNumbGrad.AutoSize = true;
            this.txtNumbGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbGrad.Location = new System.Drawing.Point(72, 90);
            this.txtNumbGrad.Name = "txtNumbGrad";
            this.txtNumbGrad.Size = new System.Drawing.Size(158, 25);
            this.txtNumbGrad.TabIndex = 2;
            this.txtNumbGrad.Text = "Number Grade:";
            this.txtNumbGrad.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLetGrad
            // 
            this.txtLetGrad.AutoSize = true;
            this.txtLetGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetGrad.Location = new System.Drawing.Point(72, 122);
            this.txtLetGrad.Name = "txtLetGrad";
            this.txtLetGrad.Size = new System.Drawing.Size(125, 25);
            this.txtLetGrad.TabIndex = 3;
            this.txtLetGrad.Text = "Text Grade:";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(249, 87);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 31);
            this.txtInput.TabIndex = 4;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOuput
            // 
            this.txtOuput.Cursor = System.Windows.Forms.Cursors.No;
            this.txtOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOuput.Location = new System.Drawing.Point(249, 122);
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.ReadOnly = true;
            this.txtOuput.Size = new System.Drawing.Size(100, 31);
            this.txtOuput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 283);
            this.Controls.Add(this.txtOuput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtLetGrad);
            this.Controls.Add(this.txtNumbGrad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txtNumbGrad;
        private System.Windows.Forms.Label txtLetGrad;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOuput;
    }
}

