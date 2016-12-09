namespace Tu_Dien_1._1
{
    partial class studyVocabulary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studyVocabulary));
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbViet = new System.Windows.Forms.CheckBox();
            this.cbAnh = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbMean = new System.Windows.Forms.Label();
            this.lbVoca = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDung = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbExp = new System.Windows.Forms.CheckBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(86, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // cbViet
            // 
            this.cbViet.AutoSize = true;
            this.cbViet.Location = new System.Drawing.Point(1, 44);
            this.cbViet.Name = "cbViet";
            this.cbViet.Size = new System.Drawing.Size(52, 17);
            this.cbViet.TabIndex = 1;
            this.cbViet.Text = "Mean";
            this.cbViet.UseVisualStyleBackColor = true;
            this.cbViet.CheckedChanged += new System.EventHandler(this.cbViet_CheckedChanged);
            // 
            // cbAnh
            // 
            this.cbAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAnh.AutoSize = true;
            this.cbAnh.Location = new System.Drawing.Point(0, 117);
            this.cbAnh.Name = "cbAnh";
            this.cbAnh.Size = new System.Drawing.Size(79, 17);
            this.cbAnh.TabIndex = 1;
            this.cbAnh.Text = "Vocabulary";
            this.cbAnh.UseVisualStyleBackColor = true;
            this.cbAnh.CheckedChanged += new System.EventHandler(this.cbAnh_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbMean
            // 
            this.lbMean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMean.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMean.Location = new System.Drawing.Point(83, 45);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(200, 57);
            this.lbMean.TabIndex = 2;
            // 
            // lbVoca
            // 
            this.lbVoca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVoca.AutoSize = true;
            this.lbVoca.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoca.ForeColor = System.Drawing.Color.Red;
            this.lbVoca.Location = new System.Drawing.Point(83, 109);
            this.lbVoca.Name = "lbVoca";
            this.lbVoca.Size = new System.Drawing.Size(0, 18);
            this.lbVoca.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "CheckError";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đúng/Sai";
            // 
            // lbDung
            // 
            this.lbDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDung.AutoSize = true;
            this.lbDung.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDung.Location = new System.Drawing.Point(298, 44);
            this.lbDung.Name = "lbDung";
            this.lbDung.Size = new System.Drawing.Size(0, 16);
            this.lbDung.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(301, 79);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(60, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Reset";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(198, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Hình Ảnh";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbExp
            // 
            this.cbExp.AutoSize = true;
            this.cbExp.Location = new System.Drawing.Point(1, 68);
            this.cbExp.Name = "cbExp";
            this.cbExp.Size = new System.Drawing.Size(49, 17);
            this.cbExp.TabIndex = 10;
            this.cbExp.Text = "Ví dụ";
            this.cbExp.UseVisualStyleBackColor = true;
            this.cbExp.CheckedChanged += new System.EventHandler(this.cbExp_CheckedChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(301, 108);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(60, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Next";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // studyVocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 134);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cbExp);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lbDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbVoca);
            this.Controls.Add(this.lbMean);
            this.Controls.Add(this.cbAnh);
            this.Controls.Add(this.cbViet);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "studyVocabulary";
            this.Text = "Học từ";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studyVocabulary_FormClosed);
            this.Load += new System.EventHandler(this.studyVocabulary_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studyVocabulary_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbViet;
        private System.Windows.Forms.CheckBox cbAnh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbVoca;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbDung;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbExp;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}