
namespace Example
{
    partial class Sturct_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sturct_Class));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboxSun = new System.Windows.Forms.PictureBox();
            this.pboxMoon = new System.Windows.Forms.PictureBox();
            this.pboxStar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.lboxResult1 = new System.Windows.Forms.ListBox();
            this.lboxResult2 = new System.Windows.Forms.ListBox();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player는 한번 씩 돌아가면서 그림을 선택합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "각 10회 진행 후 해, 달, 별의 숫자의 합이 가장 높은 사람이 승리합니다.";
            // 
            // pboxSun
            // 
            this.pboxSun.Cursor = System.Windows.Forms.Cursors.Default;
            this.pboxSun.Image = global::Example.Properties.Resources._1;
            this.pboxSun.Location = new System.Drawing.Point(39, 78);
            this.pboxSun.Name = "pboxSun";
            this.pboxSun.Size = new System.Drawing.Size(115, 137);
            this.pboxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSun.TabIndex = 1;
            this.pboxSun.TabStop = false;
            this.pboxSun.Click += new System.EventHandler(this.All_button_Click);
            // 
            // pboxMoon
            // 
            this.pboxMoon.Image = ((System.Drawing.Image)(resources.GetObject("pboxMoon.Image")));
            this.pboxMoon.Location = new System.Drawing.Point(181, 78);
            this.pboxMoon.Name = "pboxMoon";
            this.pboxMoon.Size = new System.Drawing.Size(109, 137);
            this.pboxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMoon.TabIndex = 1;
            this.pboxMoon.TabStop = false;
            this.pboxMoon.Click += new System.EventHandler(this.All_button_Click);
            // 
            // pboxStar
            // 
            this.pboxStar.Image = ((System.Drawing.Image)(resources.GetObject("pboxStar.Image")));
            this.pboxStar.Location = new System.Drawing.Point(320, 78);
            this.pboxStar.Name = "pboxStar";
            this.pboxStar.Size = new System.Drawing.Size(106, 137);
            this.pboxStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxStar.TabIndex = 1;
            this.pboxStar.TabStop = false;
            this.pboxStar.Click += new System.EventHandler(this.All_button_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox4.Location = new System.Drawing.Point(456, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 137);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.All_button_Click);
            // 
            // rdoPlayer1
            // 
            this.rdoPlayer1.AutoSize = true;
            this.rdoPlayer1.Checked = true;
            this.rdoPlayer1.Location = new System.Drawing.Point(25, 255);
            this.rdoPlayer1.Name = "rdoPlayer1";
            this.rdoPlayer1.Size = new System.Drawing.Size(65, 16);
            this.rdoPlayer1.TabIndex = 3;
            this.rdoPlayer1.TabStop = true;
            this.rdoPlayer1.Text = "Player1";
            this.rdoPlayer1.UseVisualStyleBackColor = true;
            // 
            // lboxResult1
            // 
            this.lboxResult1.FormattingEnabled = true;
            this.lboxResult1.ItemHeight = 12;
            this.lboxResult1.Location = new System.Drawing.Point(25, 291);
            this.lboxResult1.Name = "lboxResult1";
            this.lboxResult1.Size = new System.Drawing.Size(299, 148);
            this.lboxResult1.TabIndex = 4;
            // 
            // lboxResult2
            // 
            this.lboxResult2.FormattingEnabled = true;
            this.lboxResult2.ItemHeight = 12;
            this.lboxResult2.Location = new System.Drawing.Point(355, 291);
            this.lboxResult2.Name = "lboxResult2";
            this.lboxResult2.Size = new System.Drawing.Size(285, 148);
            this.lboxResult2.TabIndex = 4;
            // 
            // rdoPlayer2
            // 
            this.rdoPlayer2.AutoSize = true;
            this.rdoPlayer2.Location = new System.Drawing.Point(355, 255);
            this.rdoPlayer2.Name = "rdoPlayer2";
            this.rdoPlayer2.Size = new System.Drawing.Size(65, 16);
            this.rdoPlayer2.TabIndex = 5;
            this.rdoPlayer2.TabStop = true;
            this.rdoPlayer2.Text = "Player2";
            this.rdoPlayer2.UseVisualStyleBackColor = true;
            // 
            // Sturct_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 514);
            this.Controls.Add(this.rdoPlayer2);
            this.Controls.Add(this.lboxResult2);
            this.Controls.Add(this.lboxResult1);
            this.Controls.Add(this.rdoPlayer1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pboxStar);
            this.Controls.Add(this.pboxMoon);
            this.Controls.Add(this.pboxSun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sturct_Class";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pboxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboxSun;
        private System.Windows.Forms.PictureBox pboxMoon;
        private System.Windows.Forms.PictureBox pboxStar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.ListBox lboxResult1;
        private System.Windows.Forms.ListBox lboxResult2;
        private System.Windows.Forms.RadioButton rdoPlayer2;
    }
}