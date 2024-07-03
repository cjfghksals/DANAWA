namespace DANAWA
{
    partial class Buy
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            BuyWant = new System.Windows.Forms.TextBox();
            BuyAddress = new System.Windows.Forms.TextBox();
            BuyName = new System.Windows.Forms.Label();
            BuyPhoneNumaber = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            BuyTotalPrice = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            BuyComplete = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            tabPage3 = new System.Windows.Forms.TabPage();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            CompletePrice = new System.Windows.Forms.Label();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BuyComplete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(19, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(161, 41);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(18, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 28);
            label1.TabIndex = 1;
            label1.Text = "결제 정보 입력";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(19, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "주문자 명";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(19, 143);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 21);
            label3.TabIndex = 2;
            label3.Text = "주문 연락처";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(19, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 21);
            label4.TabIndex = 2;
            label4.Text = "배송 주소";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(19, 234);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 21);
            label5.TabIndex = 2;
            label5.Text = "요청사항";
            label5.Click += label4_Click;
            // 
            // BuyWant
            // 
            BuyWant.Location = new System.Drawing.Point(130, 233);
            BuyWant.Name = "BuyWant";
            BuyWant.Size = new System.Drawing.Size(366, 23);
            BuyWant.TabIndex = 4;
            // 
            // BuyAddress
            // 
            BuyAddress.Location = new System.Drawing.Point(130, 186);
            BuyAddress.Name = "BuyAddress";
            BuyAddress.Size = new System.Drawing.Size(366, 23);
            BuyAddress.TabIndex = 4;
            // 
            // BuyName
            // 
            BuyName.AutoSize = true;
            BuyName.Location = new System.Drawing.Point(130, 106);
            BuyName.Name = "BuyName";
            BuyName.Size = new System.Drawing.Size(46, 15);
            BuyName.TabIndex = 5;
            BuyName.Text = "label10";
            // 
            // BuyPhoneNumaber
            // 
            BuyPhoneNumaber.AutoSize = true;
            BuyPhoneNumaber.Location = new System.Drawing.Point(130, 148);
            BuyPhoneNumaber.Name = "BuyPhoneNumaber";
            BuyPhoneNumaber.Size = new System.Drawing.Size(46, 15);
            BuyPhoneNumaber.TabIndex = 5;
            BuyPhoneNumaber.Text = "label10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(18, 281);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(102, 21);
            label10.TabIndex = 6;
            label10.Text = "총 주문 금액";
            // 
            // BuyTotalPrice
            // 
            BuyTotalPrice.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BuyTotalPrice.ForeColor = System.Drawing.Color.Blue;
            BuyTotalPrice.Location = new System.Drawing.Point(19, 344);
            BuyTotalPrice.Name = "BuyTotalPrice";
            BuyTotalPrice.Size = new System.Drawing.Size(477, 55);
            BuyTotalPrice.TabIndex = 6;
            BuyTotalPrice.Text = "원";
            BuyTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.LightGray;
            label6.Location = new System.Drawing.Point(-1, 131);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(519, 1);
            label6.TabIndex = 7;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.LightGray;
            label7.Location = new System.Drawing.Point(1, 220);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(519, 1);
            label7.TabIndex = 7;
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.Color.LightGray;
            label8.Location = new System.Drawing.Point(1, 173);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(519, 1);
            label8.TabIndex = 7;
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.LightGray;
            label9.Location = new System.Drawing.Point(-1, 269);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(519, 1);
            label9.TabIndex = 7;
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.LightGray;
            label11.Location = new System.Drawing.Point(1, 444);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(519, 1);
            label11.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(214, 477);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(282, 42);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(301, 477);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(197, 42);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(41, 448);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(153, 91);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(-5, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(510, 588);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.White;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(BuyWant);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(BuyAddress);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(BuyName);
            tabPage1.Controls.Add(BuyTotalPrice);
            tabPage1.Controls.Add(BuyPhoneNumaber);
            tabPage1.Controls.Add(label10);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(502, 560);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BuyComplete);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(502, 560);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BuyComplete
            // 
            BuyComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            BuyComplete.Image = (System.Drawing.Image)resources.GetObject("BuyComplete.Image");
            BuyComplete.Location = new System.Drawing.Point(130, 474);
            BuyComplete.Name = "BuyComplete";
            BuyComplete.Size = new System.Drawing.Size(240, 50);
            BuyComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BuyComplete.TabIndex = 1;
            BuyComplete.TabStop = false;
            BuyComplete.Click += BuyComplete_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(-99, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(698, 539);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox7);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(CompletePrice);
            tabPage3.Controls.Add(pictureBox6);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(502, 560);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new System.Drawing.Point(44, 428);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(417, 98);
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.White;
            label13.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label13.ForeColor = System.Drawing.Color.DarkGray;
            label13.Location = new System.Drawing.Point(211, 321);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(240, 23);
            label13.TabIndex = 2;
            label13.Text = "2024.01.29 15:47:23";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.BackColor = System.Drawing.Color.White;
            label12.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.Color.DarkGray;
            label12.Location = new System.Drawing.Point(280, 360);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(171, 23);
            label12.TabIndex = 2;
            label12.Text = "다나와";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompletePrice
            // 
            CompletePrice.BackColor = System.Drawing.Color.White;
            CompletePrice.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CompletePrice.Location = new System.Drawing.Point(56, 61);
            CompletePrice.Name = "CompletePrice";
            CompletePrice.Size = new System.Drawing.Size(398, 83);
            CompletePrice.TabIndex = 1;
            CompletePrice.Text = "label12";
            CompletePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = System.Drawing.Color.White;
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new System.Drawing.Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(502, 537);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // Buy
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(501, 560);
            Controls.Add(tabControl1);
            Name = "Buy";
            Text = "Buy";
            Load += Buy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BuyComplete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BuyWant;
        private System.Windows.Forms.TextBox BuyAddress;
        private System.Windows.Forms.Label BuyName;
        private System.Windows.Forms.Label BuyPhoneNumaber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label BuyTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox BuyComplete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CompletePrice;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label13;
    }
}