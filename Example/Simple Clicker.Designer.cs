
namespace Example
{
    partial class Simple_Clicker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTickerPoint = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btn1Add = new System.Windows.Forms.Button();
            this.btn3Add = new System.Windows.Forms.Button();
            this.btn50Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tick Point : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn50Add);
            this.groupBox1.Controls.Add(this.btn3Add);
            this.groupBox1.Controls.Add(this.btn1Add);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblTickerPoint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "점수";
            // 
            // lblTickerPoint
            // 
            this.lblTickerPoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTickerPoint.Location = new System.Drawing.Point(92, 17);
            this.lblTickerPoint.Name = "lblTickerPoint";
            this.lblTickerPoint.Size = new System.Drawing.Size(284, 27);
            this.lblTickerPoint.TabIndex = 1;
            this.lblTickerPoint.Text = "0";
            this.lblTickerPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotal.Location = new System.Drawing.Point(13, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(377, 111);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1Add
            // 
            this.btn1Add.Location = new System.Drawing.Point(6, 169);
            this.btn1Add.Name = "btn1Add";
            this.btn1Add.Size = new System.Drawing.Size(169, 34);
            this.btn1Add.TabIndex = 2;
            this.btn1Add.Text = "+1";
            this.btn1Add.UseVisualStyleBackColor = true;
            this.btn1Add.Click += new System.EventHandler(this.btn1Add_Click);
            // 
            // btn3Add
            // 
            this.btn3Add.Location = new System.Drawing.Point(6, 218);
            this.btn3Add.Name = "btn3Add";
            this.btn3Add.Size = new System.Drawing.Size(169, 34);
            this.btn3Add.TabIndex = 2;
            this.btn3Add.Text = "+3";
            this.btn3Add.UseVisualStyleBackColor = true;
            this.btn3Add.Click += new System.EventHandler(this.btn1Add_Click);
            // 
            // btn50Add
            // 
            this.btn50Add.Location = new System.Drawing.Point(6, 271);
            this.btn50Add.Name = "btn50Add";
            this.btn50Add.Size = new System.Drawing.Size(169, 34);
            this.btn50Add.TabIndex = 2;
            this.btn50Add.Text = "+50";
            this.btn50Add.UseVisualStyleBackColor = true;
            this.btn50Add.Click += new System.EventHandler(this.btn1Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "(100)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "(500)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "(5000)";
            // 
            // Simple_Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 350);
            this.Controls.Add(this.groupBox1);
            this.Name = "Simple_Clicker";
            this.Text = "Simple_Clicker";
            this.Load += new System.EventHandler(this.Simple_Clicker_Load);
            this.FormClosed += Simple_Clicker_FormClosed;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn50Add;
        private System.Windows.Forms.Button btn3Add;
        private System.Windows.Forms.Button btn1Add;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTickerPoint;
    }
}