
namespace Example
{
    partial class Inheritance
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
            this.pMain = new System.Windows.Forms.Panel();
            this.btnOneCycle = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pMain.Location = new System.Drawing.Point(28, 26);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(600, 300);
            this.pMain.TabIndex = 0;
            // 
            // btnOneCycle
            // 
            this.btnOneCycle.Location = new System.Drawing.Point(118, 336);
            this.btnOneCycle.Name = "btnOneCycle";
            this.btnOneCycle.Size = new System.Drawing.Size(168, 23);
            this.btnOneCycle.TabIndex = 1;
            this.btnOneCycle.Text = "1단계 : 외발 자전거";
            this.btnOneCycle.UseVisualStyleBackColor = true;
            this.btnOneCycle.Click += new System.EventHandler(this.btnOneCycle_Click);
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(292, 336);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(147, 23);
            this.btnCycle.TabIndex = 2;
            this.btnCycle.Text = "2단계 : 자전거";
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(445, 336);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(148, 23);
            this.btnCar.TabIndex = 3;
            this.btnCar.Text = "3단계 : 자동차";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(228, 365);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(129, 39);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<---";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(379, 365);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(126, 39);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "-->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(12, 336);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 7;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inheritance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 427);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnOneCycle);
            this.Controls.Add(this.pMain);
            this.KeyPreview = true;
            this.Name = "Inheritance";
            this.Text = "Inheritance";
            this.Load += new System.EventHandler(this.Inheritance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnOneCycle;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblName;
    }
}