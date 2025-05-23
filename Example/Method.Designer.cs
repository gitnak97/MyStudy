
namespace Example
{
    partial class Method
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tAnswer = new System.Windows.Forms.TextBox();
            this.tNumber1 = new System.Windows.Forms.TextBox();
            this.tNumber2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 21);
            this.textBox1.TabIndex = 0;
            // 
            // tAnswer
            // 
            this.tAnswer.Location = new System.Drawing.Point(26, 23);
            this.tAnswer.Name = "tAnswer";
            this.tAnswer.Size = new System.Drawing.Size(218, 21);
            this.tAnswer.TabIndex = 0;
            this.tAnswer.Text = "0";
            // 
            // tNumber1
            // 
            this.tNumber1.Location = new System.Drawing.Point(26, 62);
            this.tNumber1.Name = "tNumber1";
            this.tNumber1.Size = new System.Drawing.Size(99, 21);
            this.tNumber1.TabIndex = 1;
            this.tNumber1.Text = "0";
            // 
            // tNumber2
            // 
            this.tNumber2.Location = new System.Drawing.Point(143, 62);
            this.tNumber2.Name = "tNumber2";
            this.tNumber2.Size = new System.Drawing.Size(101, 21);
            this.tNumber2.TabIndex = 1;
            this.tNumber2.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(30, 112);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(47, 43);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(83, 112);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(47, 43);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(136, 112);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(47, 43);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(189, 112);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(47, 43);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "=";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 387);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tNumber2);
            this.Controls.Add(this.tNumber1);
            this.Controls.Add(this.tAnswer);
            this.Controls.Add(this.textBox1);
            this.Name = "Method";
            this.Text = "Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tAnswer;
        private System.Windows.Forms.TextBox tNumber1;
        private System.Windows.Forms.TextBox tNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
    }
}