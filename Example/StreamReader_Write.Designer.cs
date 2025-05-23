
namespace Example
{
    partial class StreamReader_Write
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tboxConfigData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxData = new System.Windows.Forms.CheckBox();
            this.numData = new System.Windows.Forms.NumericUpDown();
            this.btnConfigSet = new System.Windows.Forms.Button();
            this.btnConfigRead = new System.Windows.Forms.Button();
            this.SFDialog = new System.Windows.Forms.SaveFileDialog();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Text 읽어오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Text 저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tboxConfigData
            // 
            this.tboxConfigData.Location = new System.Drawing.Point(9, 37);
            this.tboxConfigData.Multiline = true;
            this.tboxConfigData.Name = "tboxConfigData";
            this.tboxConfigData.Size = new System.Drawing.Size(305, 235);
            this.tboxConfigData.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numData);
            this.groupBox1.Controls.Add(this.cboxData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxData);
            this.groupBox1.Location = new System.Drawing.Point(19, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // tboxData
            // 
            this.tboxData.Location = new System.Drawing.Point(85, 20);
            this.tboxData.Name = "tboxData";
            this.tboxData.Size = new System.Drawing.Size(100, 21);
            this.tboxData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Text : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Check Box : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "3. Number : ";
            // 
            // cboxData
            // 
            this.cboxData.AutoSize = true;
            this.cboxData.Location = new System.Drawing.Point(117, 55);
            this.cboxData.Name = "cboxData";
            this.cboxData.Size = new System.Drawing.Size(47, 16);
            this.cboxData.TabIndex = 2;
            this.cboxData.Text = "CB1";
            this.cboxData.UseVisualStyleBackColor = true;
            // 
            // numData
            // 
            this.numData.Location = new System.Drawing.Point(94, 82);
            this.numData.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numData.Name = "numData";
            this.numData.Size = new System.Drawing.Size(120, 21);
            this.numData.TabIndex = 3;
            // 
            // btnConfigSet
            // 
            this.btnConfigSet.Location = new System.Drawing.Point(188, 406);
            this.btnConfigSet.Name = "btnConfigSet";
            this.btnConfigSet.Size = new System.Drawing.Size(126, 28);
            this.btnConfigSet.TabIndex = 3;
            this.btnConfigSet.Text = "Config 설정하기";
            this.btnConfigSet.UseVisualStyleBackColor = true;
            this.btnConfigSet.Click += new System.EventHandler(this.btnConfigSet_Click);
            // 
            // btnConfigRead
            // 
            this.btnConfigRead.Location = new System.Drawing.Point(19, 406);
            this.btnConfigRead.Name = "btnConfigRead";
            this.btnConfigRead.Size = new System.Drawing.Size(126, 28);
            this.btnConfigRead.TabIndex = 4;
            this.btnConfigRead.Text = "Config 가져오기";
            this.btnConfigRead.UseVisualStyleBackColor = true;
            this.btnConfigRead.Click += new System.EventHandler(this.btnConfigRead_Click);
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "openFileDialog1";
            // 
            // StreamReader_Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 437);
            this.Controls.Add(this.btnConfigSet);
            this.Controls.Add(this.btnConfigRead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboxConfigData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "StreamReader_Write";
            this.Text = "StreamReader_Write";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tboxConfigData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numData;
        private System.Windows.Forms.CheckBox cboxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxData;
        private System.Windows.Forms.Button btnConfigSet;
        private System.Windows.Forms.Button btnConfigRead;
        private System.Windows.Forms.SaveFileDialog SFDialog;
        private System.Windows.Forms.OpenFileDialog OFDialog;
    }
}