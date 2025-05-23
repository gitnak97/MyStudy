
namespace Example
{
    partial class DataType
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
            this.tBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exception = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.btntBox = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxNumber
            // 
            this.tBoxNumber.Location = new System.Drawing.Point(12, 12);
            this.tBoxNumber.Name = "tBoxNumber";
            this.tBoxNumber.Size = new System.Drawing.Size(585, 21);
            this.tBoxNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Double";
            // 
            // Exception
            // 
            this.Exception.AutoSize = true;
            this.Exception.Location = new System.Drawing.Point(32, 173);
            this.Exception.Name = "Exception";
            this.Exception.Size = new System.Drawing.Size(61, 12);
            this.Exception.TabIndex = 1;
            this.Exception.Text = "Exception";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Int";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(100, 69);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(11, 12);
            this.lblShort.TabIndex = 1;
            this.lblShort.Text = "0";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(100, 138);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(11, 12);
            this.lblDouble.TabIndex = 1;
            this.lblDouble.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(100, 106);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(11, 12);
            this.lblInt.TabIndex = 1;
            this.lblInt.Text = "0";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(100, 173);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(11, 12);
            this.lblException.TabIndex = 1;
            this.lblException.Text = "-";
            // 
            // btntBox
            // 
            this.btntBox.Location = new System.Drawing.Point(603, 7);
            this.btntBox.Name = "btntBox";
            this.btntBox.Size = new System.Drawing.Size(99, 28);
            this.btntBox.TabIndex = 2;
            this.btntBox.Text = "알아서 변환";
            this.btntBox.UseVisualStyleBackColor = true;
            this.btntBox.Click += new System.EventHandler(this.btntBox_Click);
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(217, 61);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(99, 28);
            this.btnShort.TabIndex = 2;
            this.btnShort.Text = "Short 변환";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(217, 95);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(99, 28);
            this.btnInt.TabIndex = 2;
            this.btnInt.Text = "Int 변환";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(217, 130);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(99, 28);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "Double 변환";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // DataType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btntBox);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.Exception);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxNumber);
            this.Name = "DataType";
            this.Text = "DataType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Exception;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Button btntBox;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
    }
}