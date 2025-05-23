
namespace Example
{
    partial class EnumClass
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
            this.lboxItem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.cboxRate = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxErrorMsg = new System.Windows.Forms.TextBox();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxItem
            // 
            this.lboxItem.FormattingEnabled = true;
            this.lboxItem.ItemHeight = 12;
            this.lboxItem.Location = new System.Drawing.Point(12, 21);
            this.lboxItem.Name = "lboxItem";
            this.lboxItem.Size = new System.Drawing.Size(267, 232);
            this.lboxItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "물건";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "할인율(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "개수";
            // 
            // cboxItem
            // 
            this.cboxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(323, 50);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(121, 20);
            this.cboxItem.TabIndex = 2;
            // 
            // cboxRate
            // 
            this.cboxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRate.FormattingEnabled = true;
            this.cboxRate.Location = new System.Drawing.Point(323, 132);
            this.cboxRate.Name = "cboxRate";
            this.cboxRate.Size = new System.Drawing.Size(121, 20);
            this.cboxRate.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(323, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(15, 311);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(209, 21);
            this.tboxResult.TabIndex = 4;
            // 
            // tboxErrorMsg
            // 
            this.tboxErrorMsg.Location = new System.Drawing.Point(15, 364);
            this.tboxErrorMsg.Name = "tboxErrorMsg";
            this.tboxErrorMsg.Size = new System.Drawing.Size(408, 21);
            this.tboxErrorMsg.TabIndex = 4;
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(323, 212);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(121, 21);
            this.numCount.TabIndex = 5;
            // 
            // EnumClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 430);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.tboxErrorMsg);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxRate);
            this.Controls.Add(this.cboxItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxItem);
            this.Name = "EnumClass";
            this.Text = "EnumClass";
            this.Load += new System.EventHandler(this.EnumClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxItem;
        private System.Windows.Forms.ComboBox cboxRate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxErrorMsg;
        private System.Windows.Forms.NumericUpDown numCount;
    }
}