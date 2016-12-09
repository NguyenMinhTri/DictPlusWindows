namespace Tu_Dien_1._1
{
    partial class FormSOHA
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
            DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
            DevExpress.XtraBars.FormAssistant formAssistant1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSOHA));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bcNormal = new DevExpress.XtraBars.BarCheckItem();
            this.bcHL = new DevExpress.XtraBars.BarCheckItem();
            this.bcCB = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.bcTT = new DevExpress.XtraBars.BarCheckItem();
            this.bcKT = new DevExpress.XtraBars.BarCheckItem();
            this.bcDD = new DevExpress.XtraBars.BarCheckItem();
            this.bcOxF = new DevExpress.XtraBars.BarCheckItem();
            bcThongDung = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.bcOF = new DevExpress.XtraBars.BarCheckItem();
            this.bcBing = new DevExpress.XtraBars.BarCheckItem();
            this.bcSOHA = new DevExpress.XtraBars.BarCheckItem();
            this.bcLV = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.bcSpeak = new DevExpress.XtraBars.BarCheckItem();
            this.bcOnly = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barToolbarsListItem2 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.label1 = new System.Windows.Forms.Label();
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser2
            // 
            resources.ApplyResources(this.webBrowser2, "webBrowser2");
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.HideToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            resources.ApplyResources(this.closeToolStripMenuItem1, "closeToolStripMenuItem1");
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.bcNormal,
            this.bcHL,
            this.bcCB,
            this.barSubItem2,
            this.bcTT,
            this.bcKT,
            this.barSubItem3,
            this.bcOF,
            this.bcBing,
            this.bcSOHA,
            this.bcLV,
            this.barEditItem1,
            this.barToolbarsListItem1,
            this.barToolbarsListItem2,
            this.barSubItem4,
            this.bcSpeak,
            this.bcOnly,
            this.bcDD,
            this.bcOxF,
            this.barCheckItem1,
            bcThongDung});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 23;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // barSubItem1
            // 
            resources.ApplyResources(this.barSubItem1, "barSubItem1");
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcNormal),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcHL),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcCB),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bcNormal
            // 
            resources.ApplyResources(this.bcNormal, "bcNormal");
            this.bcNormal.Checked = true;
            this.bcNormal.Id = 1;
            this.bcNormal.Name = "bcNormal";
            this.bcNormal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_ItemClick);
            // 
            // bcHL
            // 
            resources.ApplyResources(this.bcHL, "bcHL");
            this.bcHL.Id = 2;
            this.bcHL.Name = "bcHL";
            this.bcHL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem2_ItemClick);
            // 
            // bcCB
            // 
            resources.ApplyResources(this.bcCB, "bcCB");
            this.bcCB.Id = 3;
            this.bcCB.Name = "bcCB";
            this.bcCB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem3_ItemClick);
            // 
            // barCheckItem1
            // 
            resources.ApplyResources(this.barCheckItem1, "barCheckItem1");
            this.barCheckItem1.Id = 21;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_ItemClick_1);
            // 
            // barSubItem2
            // 
            resources.ApplyResources(this.barSubItem2, "barSubItem2");
            this.barSubItem2.Id = 4;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcTT),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcKT),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcDD),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcOxF),
            new DevExpress.XtraBars.LinkPersistInfo(bcThongDung)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // bcTT
            // 
            resources.ApplyResources(this.bcTT, "bcTT");
            this.bcTT.Id = 5;
            this.bcTT.Name = "bcTT";
            this.bcTT.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bcTT_CheckedChanged);
            this.bcTT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem4_ItemClick);
            // 
            // bcKT
            // 
            resources.ApplyResources(this.bcKT, "bcKT");
            this.bcKT.Id = 6;
            this.bcKT.Name = "bcKT";
            this.bcKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem5_ItemClick);
            // 
            // bcDD
            // 
            resources.ApplyResources(this.bcDD, "bcDD");
            this.bcDD.Id = 18;
            this.bcDD.Name = "bcDD";
            this.bcDD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bcDD_ItemClick);
            // 
            // bcOxF
            // 
            resources.ApplyResources(this.bcOxF, "bcOxF");
            this.bcOxF.Id = 19;
            this.bcOxF.Name = "bcOxF";
            this.bcOxF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bcOxF_ItemClick);
            // 
            // bcThongDung
            // 
            resources.ApplyResources(bcThongDung, "bcThongDung");
            bcThongDung.Checked = true;
            bcThongDung.Id = 22;
            bcThongDung.Name = "bcThongDung";
            bcThongDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bcThongDung_ItemClick);
            // 
            // barSubItem3
            // 
            resources.ApplyResources(this.barSubItem3, "barSubItem3");
            this.barSubItem3.Id = 7;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcOF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcBing),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcSOHA),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcLV)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // bcOF
            // 
            resources.ApplyResources(this.bcOF, "bcOF");
            this.bcOF.Id = 8;
            this.bcOF.Name = "bcOF";
            this.bcOF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bcOF_ItemClick);
            // 
            // bcBing
            // 
            resources.ApplyResources(this.bcBing, "bcBing");
            this.bcBing.Id = 9;
            this.bcBing.Name = "bcBing";
            this.bcBing.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bcBing_ItemClick);
            // 
            // bcSOHA
            // 
            resources.ApplyResources(this.bcSOHA, "bcSOHA");
            this.bcSOHA.Checked = true;
            this.bcSOHA.Id = 10;
            this.bcSOHA.Name = "bcSOHA";
            this.bcSOHA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bcSOHA_ItemClick);
            // 
            // bcLV
            // 
            resources.ApplyResources(this.bcLV, "bcLV");
            this.bcLV.Id = 11;
            this.bcLV.Name = "bcLV";
            this.bcLV.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bcLV_CheckedChanged);
            this.bcLV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bcLV_ItemClick);
            // 
            // barSubItem4
            // 
            resources.ApplyResources(this.barSubItem4, "barSubItem4");
            this.barSubItem4.Id = 15;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcSpeak),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcOnly)});
            this.barSubItem4.Name = "barSubItem4";
            this.barSubItem4.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barSubItem4_ItemPress);
            // 
            // bcSpeak
            // 
            resources.ApplyResources(this.bcSpeak, "bcSpeak");
            this.bcSpeak.Id = 16;
            this.bcSpeak.Name = "bcSpeak";
            // 
            // bcOnly
            // 
            resources.ApplyResources(this.bcOnly, "bcOnly");
            this.bcOnly.Id = 17;
            this.bcOnly.Name = "bcOnly";
            this.bcOnly.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bcOnly_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            // 
            // barEditItem1
            // 
            resources.ApplyResources(this.barEditItem1, "barEditItem1");
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 12;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoComplete = false;
            resources.ApplyResources(this.repositoryItemComboBox1, "repositoryItemComboBox1");
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox1.Buttons"))))});
            this.repositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemComboBox1.DropDownRows = 1;
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barToolbarsListItem1
            // 
            resources.ApplyResources(this.barToolbarsListItem1, "barToolbarsListItem1");
            this.barToolbarsListItem1.Id = 13;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barToolbarsListItem2
            // 
            resources.ApplyResources(this.barToolbarsListItem2, "barToolbarsListItem2");
            this.barToolbarsListItem2.Id = 14;
            this.barToolbarsListItem2.Name = "barToolbarsListItem2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // FormSOHA
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Name = "FormSOHA";
            this.ShowInTaskbar = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSOHA_FormClosed);
            this.Load += new System.EventHandler(this.FormSOHA_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarCheckItem bcNormal;
        private DevExpress.XtraBars.BarCheckItem bcHL;
        private DevExpress.XtraBars.BarCheckItem bcCB;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarCheckItem bcTT;
        private DevExpress.XtraBars.BarCheckItem bcKT;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarCheckItem bcOF;
        private DevExpress.XtraBars.BarCheckItem bcBing;
        private DevExpress.XtraBars.BarCheckItem bcSOHA;
        private DevExpress.XtraBars.BarCheckItem bcLV;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarCheckItem bcSpeak;
        private DevExpress.XtraBars.BarCheckItem bcOnly;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarCheckItem bcDD;
        private DevExpress.XtraBars.BarCheckItem bcOxF;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        public static DevExpress.XtraBars.BarCheckItem bcThongDung;

    }
}

