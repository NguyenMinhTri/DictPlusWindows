namespace Tu_Dien_1._1
{
    partial class tb
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Tu_Dien_1._1.SplashScreen1), true, true);
            txtWord = new System.Windows.Forms.TextBox();
            listWord = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            webBrowser1 = new System.Windows.Forms.WebBrowser();
            comboBox1 = new System.Windows.Forms.ComboBox();
            btnNghe = new System.Windows.Forms.Button();
            txStatus = new System.Windows.Forms.TextBox();
            tabOffline = new System.Windows.Forms.TabControl();
            Offline = new System.Windows.Forms.TabPage();
            cbloadImOF = new System.Windows.Forms.CheckBox();
            PicVA = new System.Windows.Forms.PictureBox();
            English = new System.Windows.Forms.ListBox();
            btnHoc = new System.Windows.Forms.TabPage();
            tbLaplai = new System.Windows.Forms.TextBox();
            cbOffline = new System.Windows.Forms.CheckBox();
            cbAutoTime = new System.Windows.Forms.CheckBox();
            tbMean = new System.Windows.Forms.TextBox();
            tbVoca = new System.Windows.Forms.TextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btnCapNhat = new System.Windows.Forms.Button();
            dataXepHang = new System.Windows.Forms.DataGridView();
            IUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ISAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ITILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ISTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnHoctu = new System.Windows.Forms.Button();
            cbNext = new System.Windows.Forms.CheckBox();
            btnTD = new System.Windows.Forms.Button();
            cbImage = new System.Windows.Forms.CheckBox();
            cbXoaTbSpeech = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            tbCK = new System.Windows.Forms.TextBox();
            cbHTB = new System.Windows.Forms.CheckBox();
            cbTHUAM = new System.Windows.Forms.CheckBox();
            cbTA = new System.Windows.Forms.CheckBox();
            cbTV = new System.Windows.Forms.CheckBox();
            btnSOHA = new System.Windows.Forms.Button();
            cbSelectALL = new System.Windows.Forms.CheckBox();
            btnXoaHis = new System.Windows.Forms.Button();
            btnTBHis = new System.Windows.Forms.Button();
            tbHistory = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Vocabulary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PhienAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Online = new System.Windows.Forms.TabPage();
            btnListen = new System.Windows.Forms.Button();
            cbbSelectLang = new System.Windows.Forms.ComboBox();
            btnTranslate = new System.Windows.Forms.Button();
            textOutput = new System.Windows.Forms.TextBox();
            textInput = new System.Windows.Forms.TextBox();
            toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            toastNotificationsManager2 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            cbLL = new System.Windows.Forms.CheckBox();
            cbToast = new System.Windows.Forms.CheckBox();
            tabOffline.SuspendLayout();
            Offline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(PicVA)).BeginInit();
            btnHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataXepHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            Online.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(toastNotificationsManager2)).BeginInit();
            SuspendLayout();
            // 
            // txtWord
            // 
            txtWord.Location = new System.Drawing.Point(3, 0);
            txtWord.Name = "txtWord";
            txtWord.Size = new System.Drawing.Size(117, 21);
            txtWord.TabIndex = 0;
            txtWord.TextChanged += new System.EventHandler(txtWord_TextChanged);
            txtWord.KeyDown += new System.Windows.Forms.KeyEventHandler(txtWord_KeyDown);
            // 
            // listWord
            // 
            listWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            listWord.FormattingEnabled = true;
            listWord.Location = new System.Drawing.Point(3, 46);
            listWord.Name = "listWord";
            listWord.Size = new System.Drawing.Size(120, 407);
            listWord.TabIndex = 1;
            listWord.Click += new System.EventHandler(listWord_Click);
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(129, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 20);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // webBrowser1
            // 
            webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            webBrowser1.Location = new System.Drawing.Point(210, 28);
            webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new System.Drawing.Size(712, 415);
            webBrowser1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "Việt - Anh",
            "Anh - Việt"});
            comboBox1.Location = new System.Drawing.Point(210, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 21);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
            // 
            // btnNghe
            // 
            btnNghe.Location = new System.Drawing.Point(129, 46);
            btnNghe.Name = "btnNghe";
            btnNghe.Size = new System.Drawing.Size(75, 23);
            btnNghe.TabIndex = 6;
            btnNghe.Text = "Nghe";
            btnNghe.UseVisualStyleBackColor = true;
            btnNghe.Click += new System.EventHandler(button2_Click_1);
            // 
            // txStatus
            // 
            txStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            txStatus.Location = new System.Drawing.Point(551, 56);
            txStatus.Name = "txStatus";
            txStatus.Size = new System.Drawing.Size(278, 21);
            txStatus.TabIndex = 18;
            txStatus.Tag = "";
            txStatus.Leave += new System.EventHandler(txStatus_Leave);
            // 
            // tabOffline
            // 
            tabOffline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabOffline.Controls.Add(Offline);
            tabOffline.Controls.Add(btnHoc);
            tabOffline.Controls.Add(Online);
            tabOffline.Location = new System.Drawing.Point(1, 0);
            tabOffline.Name = "tabOffline";
            tabOffline.SelectedIndex = 0;
            tabOffline.Size = new System.Drawing.Size(926, 537);
            tabOffline.TabIndex = 7;
            // 
            // Offline
            // 
            Offline.Controls.Add(cbloadImOF);
            Offline.Controls.Add(PicVA);
            Offline.Controls.Add(English);
            Offline.Controls.Add(listWord);
            Offline.Controls.Add(comboBox1);
            Offline.Controls.Add(btnNghe);
            Offline.Controls.Add(button1);
            Offline.Controls.Add(txtWord);
            Offline.Controls.Add(webBrowser1);
            Offline.Location = new System.Drawing.Point(4, 22);
            Offline.Margin = new System.Windows.Forms.Padding(10);
            Offline.Name = "Offline";
            Offline.Padding = new System.Windows.Forms.Padding(3);
            Offline.Size = new System.Drawing.Size(918, 511);
            Offline.TabIndex = 0;
            Offline.Text = "Offline";
            Offline.UseVisualStyleBackColor = true;
            // 
            // cbloadImOF
            // 
            cbloadImOF.AutoSize = true;
            cbloadImOF.Checked = true;
            cbloadImOF.CheckState = System.Windows.Forms.CheckState.Checked;
            cbloadImOF.Location = new System.Drawing.Point(353, 5);
            cbloadImOF.Name = "cbloadImOF";
            cbloadImOF.Size = new System.Drawing.Size(69, 17);
            cbloadImOF.TabIndex = 8;
            cbloadImOF.Text = "Hình Ảnh";
            cbloadImOF.UseVisualStyleBackColor = true;
            cbloadImOF.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
            // 
            // PicVA
            // 
            PicVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            PicVA.Location = new System.Drawing.Point(574, 231);
            PicVA.Name = "PicVA";
            PicVA.Size = new System.Drawing.Size(327, 222);
            PicVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PicVA.TabIndex = 7;
            PicVA.TabStop = false;
            // 
            // English
            // 
            English.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            English.FormattingEnabled = true;
            English.Location = new System.Drawing.Point(3, 46);
            English.Name = "English";
            English.Size = new System.Drawing.Size(120, 407);
            English.TabIndex = 1;
            English.Click += new System.EventHandler(listWord_Click);
            // 
            // btnHoc
            // 
            btnHoc.Controls.Add(cbToast);
            btnHoc.Controls.Add(cbLL);
            btnHoc.Controls.Add(tbLaplai);
            btnHoc.Controls.Add(cbOffline);
            btnHoc.Controls.Add(cbAutoTime);
            btnHoc.Controls.Add(tbMean);
            btnHoc.Controls.Add(tbVoca);
            btnHoc.Controls.Add(checkBox1);
            btnHoc.Controls.Add(label3);
            btnHoc.Controls.Add(label2);
            btnHoc.Controls.Add(labelControl1);
            btnHoc.Controls.Add(txStatus);
            btnHoc.Controls.Add(btnCapNhat);
            btnHoc.Controls.Add(dataXepHang);
            btnHoc.Controls.Add(btnHoctu);
            btnHoc.Controls.Add(cbNext);
            btnHoc.Controls.Add(btnTD);
            btnHoc.Controls.Add(cbImage);
            btnHoc.Controls.Add(cbXoaTbSpeech);
            btnHoc.Controls.Add(label1);
            btnHoc.Controls.Add(tbCK);
            btnHoc.Controls.Add(cbHTB);
            btnHoc.Controls.Add(cbTHUAM);
            btnHoc.Controls.Add(cbTA);
            btnHoc.Controls.Add(cbTV);
            btnHoc.Controls.Add(btnSOHA);
            btnHoc.Controls.Add(cbSelectALL);
            btnHoc.Controls.Add(btnXoaHis);
            btnHoc.Controls.Add(btnTBHis);
            btnHoc.Controls.Add(tbHistory);
            btnHoc.Controls.Add(dataGridView1);
            btnHoc.Location = new System.Drawing.Point(4, 22);
            btnHoc.Name = "btnHoc";
            btnHoc.Size = new System.Drawing.Size(918, 511);
            btnHoc.TabIndex = 2;
            btnHoc.Text = "History";
            btnHoc.UseVisualStyleBackColor = true;
            // 
            // tbLaplai
            // 
            tbLaplai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            tbLaplai.Location = new System.Drawing.Point(864, 434);
            tbLaplai.Name = "tbLaplai";
            tbLaplai.Size = new System.Drawing.Size(46, 21);
            tbLaplai.TabIndex = 26;
            tbLaplai.Text = "1";
            tbLaplai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tbLaplai_KeyPress);
            tbLaplai.Leave += new System.EventHandler(tbLaplai_Leave);
            // 
            // cbOffline
            // 
            cbOffline.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbOffline.AutoSize = true;
            cbOffline.Location = new System.Drawing.Point(420, 446);
            cbOffline.Name = "cbOffline";
            cbOffline.Size = new System.Drawing.Size(58, 17);
            cbOffline.TabIndex = 25;
            cbOffline.Text = "Offline";
            cbOffline.UseVisualStyleBackColor = true;
            // 
            // cbAutoTime
            // 
            cbAutoTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbAutoTime.AutoSize = true;
            cbAutoTime.Checked = true;
            cbAutoTime.CheckState = System.Windows.Forms.CheckState.Checked;
            cbAutoTime.Location = new System.Drawing.Point(330, 447);
            cbAutoTime.Name = "cbAutoTime";
            cbAutoTime.Size = new System.Drawing.Size(74, 17);
            cbAutoTime.TabIndex = 24;
            cbAutoTime.Text = "Auto Time";
            cbAutoTime.UseVisualStyleBackColor = true;
            // 
            // tbMean
            // 
            tbMean.Location = new System.Drawing.Point(284, 43);
            tbMean.Name = "tbMean";
            tbMean.Size = new System.Drawing.Size(148, 21);
            tbMean.TabIndex = 31;
            tbMean.KeyDown += new System.Windows.Forms.KeyEventHandler(tbMean_KeyDown);
            // 
            // tbVoca
            // 
            tbVoca.Location = new System.Drawing.Point(133, 43);
            tbVoca.Name = "tbVoca";
            tbVoca.Size = new System.Drawing.Size(134, 21);
            tbVoca.TabIndex = 30;
            tbVoca.KeyDown += new System.Windows.Forms.KeyEventHandler(tbVoca_KeyDown);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(7, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(70, 17);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Top Most";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(0, 371);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(862, 13);
            label3.TabIndex = 21;
            label3.Text = "Chú ý: Các lựa chọn dưới đây chỉ có tác dụng khi đã click nút \"Bắt Đầu Học Từ\", M" +
    "uốn tắt NHẮC NHỞ thì bỏ chọn trong lịch sử rồi click Nút \"Bắt Đầu Học Từ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(133, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(216, 23);
            label2.TabIndex = 20;
            label2.Text = "Lịch Sử Tra Từ Nhanh";
            // 
            // labelControl1
            // 
            labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelControl1.Location = new System.Drawing.Point(599, 26);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(143, 24);
            labelControl1.TabIndex = 19;
            labelControl1.Text = "Bảng Xếp Hạng";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnCapNhat.Location = new System.Drawing.Point(835, 56);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new System.Drawing.Size(75, 21);
            btnCapNhat.TabIndex = 17;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += new System.EventHandler(btnCapNhat_Click);
            // 
            // dataXepHang
            // 
            dataXepHang.AllowUserToAddRows = false;
            dataXepHang.AllowUserToDeleteRows = false;
            dataXepHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataXepHang.BackgroundColor = System.Drawing.Color.White;
            dataXepHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataXepHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            IUSER,
            IDUNG,
            ISAI,
            ITILE,
            ISTATUS});
            dataXepHang.GridColor = System.Drawing.Color.White;
            dataXepHang.Location = new System.Drawing.Point(551, 83);
            dataXepHang.Name = "dataXepHang";
            dataXepHang.ReadOnly = true;
            dataXepHang.RowHeadersVisible = false;
            dataXepHang.Size = new System.Drawing.Size(359, 280);
            dataXepHang.TabIndex = 16;
            // 
            // IUSER
            // 
            IUSER.DataPropertyName = "IUSER";
            IUSER.HeaderText = "User";
            IUSER.Name = "IUSER";
            IUSER.ReadOnly = true;
            // 
            // IDUNG
            // 
            IDUNG.DataPropertyName = "IDUNG";
            IDUNG.FillWeight = 10F;
            IDUNG.HeaderText = "T";
            IDUNG.Name = "IDUNG";
            IDUNG.ReadOnly = true;
            IDUNG.Width = 30;
            // 
            // ISAI
            // 
            ISAI.DataPropertyName = "ISAI";
            ISAI.HeaderText = "F";
            ISAI.Name = "ISAI";
            ISAI.ReadOnly = true;
            ISAI.Width = 30;
            // 
            // ITILE
            // 
            ITILE.DataPropertyName = "ITILE";
            ITILE.HeaderText = "Scores";
            ITILE.Name = "ITILE";
            ITILE.ReadOnly = true;
            ITILE.Width = 50;
            // 
            // ISTATUS
            // 
            ISTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ISTATUS.DataPropertyName = "ISTATUS";
            ISTATUS.HeaderText = "Status";
            ISTATUS.Name = "ISTATUS";
            ISTATUS.ReadOnly = true;
            // 
            // btnHoctu
            // 
            btnHoctu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnHoctu.Enabled = false;
            btnHoctu.Location = new System.Drawing.Point(835, 387);
            btnHoctu.Name = "btnHoctu";
            btnHoctu.Size = new System.Drawing.Size(75, 36);
            btnHoctu.TabIndex = 15;
            btnHoctu.Text = "Học từ";
            btnHoctu.UseVisualStyleBackColor = true;
            btnHoctu.Click += new System.EventHandler(btnHoctu_Click);
            // 
            // cbNext
            // 
            cbNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbNext.AutoSize = true;
            cbNext.Location = new System.Drawing.Point(330, 423);
            cbNext.Name = "cbNext";
            cbNext.Size = new System.Drawing.Size(165, 17);
            cbNext.TabIndex = 14;
            cbNext.Text = "Lặp Lại Nhắc Nhở(Đúng Qua)";
            cbNext.UseVisualStyleBackColor = true;
            // 
            // btnTD
            // 
            btnTD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnTD.Location = new System.Drawing.Point(438, 327);
            btnTD.Name = "btnTD";
            btnTD.Size = new System.Drawing.Size(75, 36);
            btnTD.TabIndex = 13;
            btnTD.Text = "Tiên Đoán";
            btnTD.UseVisualStyleBackColor = true;
            btnTD.Click += new System.EventHandler(btnTD_Click);
            // 
            // cbImage
            // 
            cbImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbImage.AutoSize = true;
            cbImage.Location = new System.Drawing.Point(3, 447);
            cbImage.Name = "cbImage";
            cbImage.Size = new System.Drawing.Size(98, 17);
            cbImage.TabIndex = 12;
            cbImage.Text = "Thêm Hình Ảnh";
            cbImage.UseVisualStyleBackColor = true;
            // 
            // cbXoaTbSpeech
            // 
            cbXoaTbSpeech.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbXoaTbSpeech.AutoSize = true;
            cbXoaTbSpeech.Location = new System.Drawing.Point(330, 392);
            cbXoaTbSpeech.Name = "cbXoaTbSpeech";
            cbXoaTbSpeech.Size = new System.Drawing.Size(158, 17);
            cbXoaTbSpeech.TabIndex = 9;
            cbXoaTbSpeech.Text = "Đọc Đúng or Học Đúng Xóa";
            cbXoaTbSpeech.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 422);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 13);
            label1.TabIndex = 8;
            label1.Text = "Chu Kì Hiện Thông Báo";
            // 
            // tbCK
            // 
            tbCK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            tbCK.Location = new System.Drawing.Point(121, 419);
            tbCK.Name = "tbCK";
            tbCK.Size = new System.Drawing.Size(21, 21);
            tbCK.TabIndex = 7;
            tbCK.Text = "1";
            tbCK.TextChanged += new System.EventHandler(tbCK_TextChanged);
            tbCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tbCK_KeyPress);
            tbCK.Leave += new System.EventHandler(tbCK_Leave);
            // 
            // cbHTB
            // 
            cbHTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbHTB.AutoSize = true;
            cbHTB.Checked = true;
            cbHTB.CheckState = System.Windows.Forms.CheckState.Checked;
            cbHTB.Location = new System.Drawing.Point(3, 392);
            cbHTB.Name = "cbHTB";
            cbHTB.Size = new System.Drawing.Size(111, 17);
            cbHTB.TabIndex = 6;
            cbHTB.Text = "Bật/Tắt Nhắc Nhở";
            cbHTB.UseVisualStyleBackColor = true;
            cbHTB.CheckedChanged += new System.EventHandler(cbHTB_CheckedChanged);
            // 
            // cbTHUAM
            // 
            cbTHUAM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbTHUAM.AutoSize = true;
            cbTHUAM.Checked = true;
            cbTHUAM.CheckState = System.Windows.Forms.CheckState.Checked;
            cbTHUAM.Location = new System.Drawing.Point(157, 447);
            cbTHUAM.Name = "cbTHUAM";
            cbTHUAM.Size = new System.Drawing.Size(110, 17);
            cbTHUAM.TabIndex = 5;
            cbTHUAM.Text = "Kiểm Tra Phát Âm";
            cbTHUAM.UseVisualStyleBackColor = true;
            // 
            // cbTA
            // 
            cbTA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbTA.AutoSize = true;
            cbTA.Checked = true;
            cbTA.CheckState = System.Windows.Forms.CheckState.Checked;
            cbTA.Location = new System.Drawing.Point(157, 422);
            cbTA.Name = "cbTA";
            cbTA.Size = new System.Drawing.Size(154, 17);
            cbTA.TabIndex = 5;
            cbTA.Text = "Đọc Tiếng Anh Khi Hiện NN";
            cbTA.UseVisualStyleBackColor = true;
            // 
            // cbTV
            // 
            cbTV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cbTV.AutoSize = true;
            cbTV.Location = new System.Drawing.Point(157, 392);
            cbTV.Name = "cbTV";
            cbTV.Size = new System.Drawing.Size(153, 17);
            cbTV.TabIndex = 5;
            cbTV.Text = "Đọc Tiếng Việt Khi Hiện NN";
            cbTV.UseVisualStyleBackColor = true;
            // 
            // btnSOHA
            // 
            btnSOHA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnSOHA.Location = new System.Drawing.Point(438, 70);
            btnSOHA.Name = "btnSOHA";
            btnSOHA.Size = new System.Drawing.Size(75, 36);
            btnSOHA.TabIndex = 4;
            btnSOHA.Text = "Tra Nhanh";
            btnSOHA.UseVisualStyleBackColor = true;
            btnSOHA.Click += new System.EventHandler(btnSOHA_Click);
            // 
            // cbSelectALL
            // 
            cbSelectALL.AutoSize = true;
            cbSelectALL.Location = new System.Drawing.Point(7, 47);
            cbSelectALL.Name = "cbSelectALL";
            cbSelectALL.Size = new System.Drawing.Size(75, 17);
            cbSelectALL.TabIndex = 3;
            cbSelectALL.Text = "Check ALL";
            cbSelectALL.UseVisualStyleBackColor = true;
            cbSelectALL.CheckedChanged += new System.EventHandler(cbSelectALL_CheckedChanged);
            // 
            // btnXoaHis
            // 
            btnXoaHis.Location = new System.Drawing.Point(88, 41);
            btnXoaHis.Name = "btnXoaHis";
            btnXoaHis.Size = new System.Drawing.Size(39, 23);
            btnXoaHis.TabIndex = 2;
            btnXoaHis.Text = "Xóa Lịch Sử";
            btnXoaHis.UseVisualStyleBackColor = true;
            btnXoaHis.Click += new System.EventHandler(btnXoaHis_Click);
            // 
            // btnTBHis
            // 
            btnTBHis.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTBHis.ForeColor = System.Drawing.Color.Red;
            btnTBHis.Location = new System.Drawing.Point(420, 0);
            btnTBHis.Name = "btnTBHis";
            btnTBHis.Size = new System.Drawing.Size(129, 40);
            btnTBHis.TabIndex = 2;
            btnTBHis.Text = "Bắt Đầu Nhắc Nhở/ Cập Nhật Lịch Sử";
            btnTBHis.UseVisualStyleBackColor = true;
            btnTBHis.Click += new System.EventHandler(btnTBHis_Click);
            // 
            // tbHistory
            // 
            tbHistory.Location = new System.Drawing.Point(908, 3);
            tbHistory.Name = "tbHistory";
            tbHistory.ReadOnly = true;
            tbHistory.Size = new System.Drawing.Size(10, 21);
            tbHistory.TabIndex = 1;
            tbHistory.Visible = false;
            tbHistory.WordWrap = false;
            tbHistory.TextChanged += new System.EventHandler(tbHistory_TextChanged);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            STT,
            Check,
            Vocabulary,
            PhienAm,
            Mean});
            dataGridView1.GridColor = System.Drawing.Color.White;
            dataGridView1.Location = new System.Drawing.Point(7, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new System.Drawing.Size(425, 298);
            dataGridView1.TabIndex = 0;
            // 
            // STT
            // 
            STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            STT.DataPropertyName = "id";
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.Visible = false;
            // 
            // Check
            // 
            Check.DataPropertyName = "ic";
            Check.HeaderText = "Check";
            Check.Name = "Check";
            Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Check.Width = 50;
            // 
            // Vocabulary
            // 
            Vocabulary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Vocabulary.DataPropertyName = "voca";
            Vocabulary.FillWeight = 103.0928F;
            Vocabulary.HeaderText = "Vocabulary";
            Vocabulary.Name = "Vocabulary";
            // 
            // PhienAm
            // 
            PhienAm.HeaderText = "Âm";
            PhienAm.Name = "PhienAm";
            PhienAm.Width = 50;
            // 
            // Mean
            // 
            Mean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Mean.DataPropertyName = "Mean";
            Mean.FillWeight = 96.90722F;
            Mean.HeaderText = "Mean";
            Mean.Name = "Mean";
            // 
            // Online
            // 
            Online.Controls.Add(btnListen);
            Online.Controls.Add(cbbSelectLang);
            Online.Controls.Add(btnTranslate);
            Online.Controls.Add(textOutput);
            Online.Controls.Add(textInput);
            Online.Location = new System.Drawing.Point(4, 22);
            Online.Name = "Online";
            Online.Padding = new System.Windows.Forms.Padding(3);
            Online.Size = new System.Drawing.Size(918, 511);
            Online.TabIndex = 1;
            Online.Text = "Online";
            Online.UseVisualStyleBackColor = true;
            // 
            // btnListen
            // 
            btnListen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnListen.Location = new System.Drawing.Point(354, 239);
            btnListen.Name = "btnListen";
            btnListen.Size = new System.Drawing.Size(111, 23);
            btnListen.TabIndex = 3;
            btnListen.Text = "Listen English";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += new System.EventHandler(btnListen_Click);
            // 
            // cbbSelectLang
            // 
            cbbSelectLang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cbbSelectLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbSelectLang.FormattingEnabled = true;
            cbbSelectLang.Items.AddRange(new object[] {
            "Anh - Việt",
            "Việt - Anh"});
            cbbSelectLang.Location = new System.Drawing.Point(187, 239);
            cbbSelectLang.Name = "cbbSelectLang";
            cbbSelectLang.Size = new System.Drawing.Size(140, 21);
            cbbSelectLang.TabIndex = 2;
            // 
            // btnTranslate
            // 
            btnTranslate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnTranslate.Location = new System.Drawing.Point(3, 237);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new System.Drawing.Size(166, 23);
            btnTranslate.TabIndex = 1;
            btnTranslate.Text = "Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += new System.EventHandler(btnTranslate_Click);
            // 
            // textOutput
            // 
            textOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            textOutput.Location = new System.Drawing.Point(6, 268);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.Size = new System.Drawing.Size(906, 192);
            textOutput.TabIndex = 0;
            // 
            // textInput
            // 
            textInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            textInput.Location = new System.Drawing.Point(7, 6);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new System.Drawing.Size(908, 225);
            textInput.TabIndex = 0;
            // 
            // toastNotificationsManager1
            // 
            toastNotificationsManager1.ApplicationId = "6b9ec18c-81e7-48b4-8ff0-5ee48a3b19b5";
            toastNotificationsManager1.ApplicationName = "DictPlus";
            // 
            // defaultLookAndFeel1
            // 
            defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // toastNotificationsManager2
            // 
            toastNotificationsManager2.ApplicationId = "37ee412e-c9a1-4d98-90bb-ee8f4c4badd1";
            toastNotificationsManager2.ApplicationName = "DemoXML";
            toastNotificationsManager2.CreateApplicationShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // cbLL
            // 
            cbLL.AutoSize = true;
            cbLL.Checked = true;
            cbLL.CheckState = System.Windows.Forms.CheckState.Checked;
            cbLL.Location = new System.Drawing.Point(518, 392);
            cbLL.Name = "cbLL";
            cbLL.Size = new System.Drawing.Size(88, 17);
            cbLL.TabIndex = 32;
            cbLL.Text = "Luôn Hiện TB";
            cbLL.UseVisualStyleBackColor = true;
            // 
            // cbToast
            // 
            cbToast.AutoSize = true;
            cbToast.Location = new System.Drawing.Point(518, 423);
            cbToast.Name = "cbToast";
            cbToast.Size = new System.Drawing.Size(53, 17);
            cbToast.TabIndex = 33;
            cbToast.Text = "Win 8";
            cbToast.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(927, 485);
            Controls.Add(tabOffline);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            Name = "tb";
            Text = "DictPlus";
            Load += new System.EventHandler(Form1_Load);
            tabOffline.ResumeLayout(false);
            Offline.ResumeLayout(false);
            Offline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(PicVA)).EndInit();
            btnHoc.ResumeLayout(false);
            btnHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataXepHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            Online.ResumeLayout(false);
            Online.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(toastNotificationsManager2)).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.ListBox listWord;
        private System.Windows.Forms.ListBox listWordAV = new System.Windows.Forms.ListBox();
        private System.Windows.Forms.DataGridView dataXepHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        public static System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNghe;
        public static System.Windows.Forms.TabControl tabOffline;
        private System.Windows.Forms.TabPage Offline;
        private System.Windows.Forms.TabPage Online;
        private System.Windows.Forms.ComboBox cbbSelectLang;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.ListBox English;
        private System.Windows.Forms.TabPage btnHoc;
        public static System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoaHis;
        private System.Windows.Forms.Button btnTBHis;
        public static System.Windows.Forms.TextBox tbHistory;
        public static System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.CheckBox cbSelectALL;
        public static System.Windows.Forms.Button btnSOHA;
        private System.Windows.Forms.CheckBox cbHTB;
        private System.Windows.Forms.CheckBox cbTHUAM;
        private System.Windows.Forms.CheckBox cbTA;
        public static System.Windows.Forms.CheckBox cbTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCK;
        private System.Windows.Forms.CheckBox cbImage;
        private System.Windows.Forms.PictureBox PicVA;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vocabulary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhienAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        public static System.Windows.Forms.Button btnTD;
        public static System.Windows.Forms.CheckBox cbNext;
        public System.Windows.Forms.Button btnHoctu;
        public static DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public static System.Windows.Forms.CheckBox cbXoaTbSpeech;
        private System.Windows.Forms.DataGridViewTextBoxColumn IUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISTATUS;
        public static System.Windows.Forms.TextBox txStatus;
        private System.Windows.Forms.CheckBox cbloadImOF;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbLaplai;
        public static System.Windows.Forms.CheckBox cbOffline;
        public static System.Windows.Forms.CheckBox cbAutoTime;
        private System.Windows.Forms.TextBox tbVoca;
        private System.Windows.Forms.TextBox tbMean;
        public static System.Windows.Forms.CheckBox cbToast;
        public static System.Windows.Forms.CheckBox cbLL;





    }
}

