
namespace Example
{
    partial class UC_endUserLbl_Check
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.expiryDate_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shippingLlb_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.custLotNo_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.waferQty_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.icQty_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partNo_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testLbl);
            this.groupBox1.Controls.Add(this.close_btn);
            this.groupBox1.Controls.Add(this.expiryDate_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.shippingLlb_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.custLotNo_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.waferQty_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.icQty_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.partNo_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "End User Label 검증";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(544, 160);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 12;
            this.close_btn.Text = "닫기";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // expiryDate_txt
            // 
            this.expiryDate_txt.Enabled = false;
            this.expiryDate_txt.Location = new System.Drawing.Point(432, 110);
            this.expiryDate_txt.Name = "expiryDate_txt";
            this.expiryDate_txt.Size = new System.Drawing.Size(172, 21);
            this.expiryDate_txt.TabIndex = 11;
            this.expiryDate_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expiryDate_txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Expiry Date";
            // 
            // shippingLlb_txt
            // 
            this.shippingLlb_txt.Enabled = false;
            this.shippingLlb_txt.Location = new System.Drawing.Point(432, 68);
            this.shippingLlb_txt.Name = "shippingLlb_txt";
            this.shippingLlb_txt.Size = new System.Drawing.Size(172, 21);
            this.shippingLlb_txt.TabIndex = 9;
            this.shippingLlb_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shippingLlb_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Shipping label";
            // 
            // custLotNo_txt
            // 
            this.custLotNo_txt.Enabled = false;
            this.custLotNo_txt.Location = new System.Drawing.Point(432, 31);
            this.custLotNo_txt.Name = "custLotNo_txt";
            this.custLotNo_txt.Size = new System.Drawing.Size(172, 21);
            this.custLotNo_txt.TabIndex = 7;
            this.custLotNo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custLotNo_txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "LOT NO";
            // 
            // waferQty_txt
            // 
            this.waferQty_txt.Enabled = false;
            this.waferQty_txt.Location = new System.Drawing.Point(113, 110);
            this.waferQty_txt.Name = "waferQty_txt";
            this.waferQty_txt.Size = new System.Drawing.Size(172, 21);
            this.waferQty_txt.TabIndex = 5;
            this.waferQty_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waferQty_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wafer QTY";
            // 
            // icQty_txt
            // 
            this.icQty_txt.Enabled = false;
            this.icQty_txt.Location = new System.Drawing.Point(113, 68);
            this.icQty_txt.Name = "icQty_txt";
            this.icQty_txt.Size = new System.Drawing.Size(172, 21);
            this.icQty_txt.TabIndex = 3;
            this.icQty_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.icQty_txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "IC QTY\r\n(Good Q\'ty)";
            // 
            // partNo_txt
            // 
            this.partNo_txt.Location = new System.Drawing.Point(113, 31);
            this.partNo_txt.Name = "partNo_txt";
            this.partNo_txt.Size = new System.Drawing.Size(172, 21);
            this.partNo_txt.TabIndex = 1;
            this.partNo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partNo_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part No";
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.Location = new System.Drawing.Point(155, 160);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(11, 12);
            this.testLbl.TabIndex = 13;
            this.testLbl.Text = "-";
            // 
            // UC_endUserLbl_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_endUserLbl_Check";
            this.Size = new System.Drawing.Size(625, 189);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox expiryDate_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox shippingLlb_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custLotNo_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox waferQty_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox icQty_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partNo_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label testLbl;
    }
}
