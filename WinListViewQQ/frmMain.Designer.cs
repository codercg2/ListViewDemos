namespace WinListViewQQ
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imageListSmallBlue = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTaskbar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemShowFrmMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemShowDeskTopIco = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemAutoRun = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonShowDesktopIcon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonScreenSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.contextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemBackImage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBgRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBgBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLargeRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLargeBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSmallRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSmallBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListLargeBlue = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmallRed = new System.Windows.Forms.ImageList(this.components);
            this.imageListLargeRed = new System.Windows.Forms.ImageList(this.components);
            this.timercpu = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarCpu = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelCPU = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStripTaskbar.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStripListView.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListSmallBlue
            // 
            this.imageListSmallBlue.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListSmallBlue.ImageSize = new System.Drawing.Size(40, 40);
            this.imageListSmallBlue.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripTaskbar;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WinQ";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStripTaskbar
            // 
            this.contextMenuStripTaskbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemShowFrmMain,
            this.toolStripMenuItem2,
            this.ToolStripMenuItemShowDeskTopIco,
            this.toolStripMenuItem3,
            this.ToolStripMenuItemAutoRun,
            this.ToolStripMenuItemTopMost,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemAbout,
            this.ToolStripMenuItemExit});
            this.contextMenuStripTaskbar.Name = "contextMenuStrip1";
            this.contextMenuStripTaskbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStripTaskbar.Size = new System.Drawing.Size(143, 154);
            this.contextMenuStripTaskbar.Paint += new System.Windows.Forms.PaintEventHandler(this.contextMenuStripTaskbar_Paint);
            this.contextMenuStripTaskbar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripTaskbar_ItemClicked);
            // 
            // ToolStripMenuItemShowFrmMain
            // 
            this.ToolStripMenuItemShowFrmMain.Name = "ToolStripMenuItemShowFrmMain";
            this.ToolStripMenuItemShowFrmMain.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemShowFrmMain.Text = "打开主面板";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(139, 6);
            // 
            // ToolStripMenuItemShowDeskTopIco
            // 
            this.ToolStripMenuItemShowDeskTopIco.Name = "ToolStripMenuItemShowDeskTopIco";
            this.ToolStripMenuItemShowDeskTopIco.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemShowDeskTopIco.Text = "隐藏桌面图标";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(139, 6);
            // 
            // ToolStripMenuItemAutoRun
            // 
            this.ToolStripMenuItemAutoRun.Name = "ToolStripMenuItemAutoRun";
            this.ToolStripMenuItemAutoRun.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemAutoRun.Text = "开机启动";
            // 
            // ToolStripMenuItemTopMost
            // 
            this.ToolStripMenuItemTopMost.Name = "ToolStripMenuItemTopMost";
            this.ToolStripMenuItemTopMost.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemTopMost.Text = "总在最上面";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemAbout.Text = "关于";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemExit.Image")));
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemExit.Text = "退出";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnFour);
            this.splitContainer1.Panel2.Controls.Add(this.btnThree);
            this.splitContainer1.Panel2.Controls.Add(this.btnTwo);
            this.splitContainer1.Panel2.Controls.Add(this.btnOne);
            this.splitContainer1.Size = new System.Drawing.Size(694, 516);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonShowDesktopIcon,
            this.toolStripSeparator1,
            this.toolStripButtonScreenSave,
            this.toolStripButton2,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonShowDesktopIcon
            // 
            this.toolStripButtonShowDesktopIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowDesktopIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowDesktopIcon.Name = "toolStripButtonShowDesktopIcon";
            this.toolStripButtonShowDesktopIcon.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowDesktopIcon.Text = "隐藏桌面图标";
            this.toolStripButtonShowDesktopIcon.Click += new System.EventHandler(this.toolStripButtonShowDesktopIcon_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonScreenSave
            // 
            this.toolStripButtonScreenSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonScreenSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonScreenSave.Image")));
            this.toolStripButtonScreenSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonScreenSave.Name = "toolStripButtonScreenSave";
            this.toolStripButtonScreenSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonScreenSave.Text = "开始屏保";
            this.toolStripButtonScreenSave.Click += new System.EventHandler(this.toolStripButtonScreenSave_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExit.Text = "退出";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(99, 257);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(79, 23);
            this.btnFour.TabIndex = 6;
            this.btnFour.Text = "我的地盘";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(39, 257);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(76, 23);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "扩 展";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.MouseLeave += new System.EventHandler(this.btnThree_MouseLeave);
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            this.btnThree.MouseEnter += new System.EventHandler(this.btnThree_MouseEnter);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(12, 228);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(103, 23);
            this.btnTwo.TabIndex = 5;
            this.btnTwo.Text = "程　序";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.MouseLeave += new System.EventHandler(this.btnTwo_MouseLeave);
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            this.btnTwo.MouseEnter += new System.EventHandler(this.btnTwo_MouseEnter);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 273);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(103, 23);
            this.btnOne.TabIndex = 4;
            this.btnOne.Text = "系 统";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.MouseLeave += new System.EventHandler(this.btnOne_MouseLeave);
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            this.btnOne.MouseEnter += new System.EventHandler(this.btnOne_MouseEnter);
            // 
            // contextMenuStripListView
            // 
            this.contextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.toolStripMenuItem5,
            this.ToolStripMenuItemBackImage,
            this.ToolStripMenuItemIcons,
            this.toolStripMenuItem4,
            this.ToolStripMenuItemAddItem,
            this.ToolStripMenuItemRemoveItem});
            this.contextMenuStripListView.Name = "contextMenuStrip2";
            this.contextMenuStripListView.Size = new System.Drawing.Size(119, 126);
            this.contextMenuStripListView.Paint += new System.Windows.Forms.PaintEventHandler(this.contextMenuStrip2_Paint);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(115, 6);
            // 
            // ToolStripMenuItemBackImage
            // 
            this.ToolStripMenuItemBackImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBgRed,
            this.ToolStripMenuItemBgBlue});
            this.ToolStripMenuItemBackImage.Name = "ToolStripMenuItemBackImage";
            this.ToolStripMenuItemBackImage.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemBackImage.Text = "背景选择";
            // 
            // ToolStripMenuItemBgRed
            // 
            this.ToolStripMenuItemBgRed.Name = "ToolStripMenuItemBgRed";
            this.ToolStripMenuItemBgRed.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemBgRed.Text = "红色";
            this.ToolStripMenuItemBgRed.Click += new System.EventHandler(this.ToolStripMenuItemBgRed_Click);
            // 
            // ToolStripMenuItemBgBlue
            // 
            this.ToolStripMenuItemBgBlue.Name = "ToolStripMenuItemBgBlue";
            this.ToolStripMenuItemBgBlue.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemBgBlue.Text = "蓝色";
            this.ToolStripMenuItemBgBlue.Click += new System.EventHandler(this.ToolStripMenuItemBgBlue_Click);
            // 
            // ToolStripMenuItemIcons
            // 
            this.ToolStripMenuItemIcons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLargeRed,
            this.ToolStripMenuItemLargeBlue,
            this.ToolStripMenuItemSmallRed,
            this.ToolStripMenuItemSmallBlue});
            this.ToolStripMenuItemIcons.Name = "ToolStripMenuItemIcons";
            this.ToolStripMenuItemIcons.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemIcons.Text = "图标";
            // 
            // ToolStripMenuItemLargeRed
            // 
            this.ToolStripMenuItemLargeRed.Name = "ToolStripMenuItemLargeRed";
            this.ToolStripMenuItemLargeRed.Size = new System.Drawing.Size(130, 22);
            this.ToolStripMenuItemLargeRed.Text = "红色大图标";
            this.ToolStripMenuItemLargeRed.Click += new System.EventHandler(this.ToolStripMenuItemLargeRed_Click);
            // 
            // ToolStripMenuItemLargeBlue
            // 
            this.ToolStripMenuItemLargeBlue.Name = "ToolStripMenuItemLargeBlue";
            this.ToolStripMenuItemLargeBlue.Size = new System.Drawing.Size(130, 22);
            this.ToolStripMenuItemLargeBlue.Text = "蓝色大图标";
            this.ToolStripMenuItemLargeBlue.Click += new System.EventHandler(this.ToolStripMenuItemLargeBlue_Click);
            // 
            // ToolStripMenuItemSmallRed
            // 
            this.ToolStripMenuItemSmallRed.Name = "ToolStripMenuItemSmallRed";
            this.ToolStripMenuItemSmallRed.Size = new System.Drawing.Size(130, 22);
            this.ToolStripMenuItemSmallRed.Text = "红色小图标";
            this.ToolStripMenuItemSmallRed.Click += new System.EventHandler(this.ToolStripMenuItemSmallRed_Click_1);
            // 
            // ToolStripMenuItemSmallBlue
            // 
            this.ToolStripMenuItemSmallBlue.Name = "ToolStripMenuItemSmallBlue";
            this.ToolStripMenuItemSmallBlue.Size = new System.Drawing.Size(130, 22);
            this.ToolStripMenuItemSmallBlue.Text = "蓝色小图标";
            this.ToolStripMenuItemSmallBlue.Click += new System.EventHandler(this.ToolStripMenuItemSmallBlue_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(115, 6);
            // 
            // ToolStripMenuItemAddItem
            // 
            this.ToolStripMenuItemAddItem.Name = "ToolStripMenuItemAddItem";
            this.ToolStripMenuItemAddItem.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemAddItem.Text = "添加项";
            this.ToolStripMenuItemAddItem.Click += new System.EventHandler(this.ToolStripMenuItemAddItem_Click);
            // 
            // ToolStripMenuItemRemoveItem
            // 
            this.ToolStripMenuItemRemoveItem.Name = "ToolStripMenuItemRemoveItem";
            this.ToolStripMenuItemRemoveItem.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemRemoveItem.Text = "移除该项";
            this.ToolStripMenuItemRemoveItem.Click += new System.EventHandler(this.ToolStripMenuItemRemoveItem_Click);
            // 
            // imageListLargeBlue
            // 
            this.imageListLargeBlue.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListLargeBlue.ImageSize = new System.Drawing.Size(100, 100);
            this.imageListLargeBlue.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListSmallRed
            // 
            this.imageListSmallRed.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListSmallRed.ImageSize = new System.Drawing.Size(40, 40);
            this.imageListSmallRed.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListLargeRed
            // 
            this.imageListLargeRed.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLargeRed.ImageSize = new System.Drawing.Size(100, 100);
            this.imageListLargeRed.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timercpu
            // 
            this.timercpu.Enabled = true;
            this.timercpu.Interval = 1000;
            this.timercpu.Tick += new System.EventHandler(this.timercpu_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel1.Text = "cpu";
            // 
            // toolStripProgressBarCpu
            // 
            this.toolStripProgressBarCpu.Name = "toolStripProgressBarCpu";
            this.toolStripProgressBarCpu.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabelCPU
            // 
            this.toolStripStatusLabelCPU.Name = "toolStripStatusLabelCPU";
            this.toolStripStatusLabelCPU.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBarCpu,
            this.toolStripStatusLabelCPU});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 516);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "ｘｐ";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripTaskbar.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStripListView.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListSmallBlue;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTaskbar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowFrmMain;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAutoRun;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTopMost;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowDeskTopIco;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListView;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowDesktopIcon;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.ImageList imageListLargeBlue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBackImage;
        private System.Windows.Forms.ImageList imageListSmallRed;
        private System.Windows.Forms.ImageList imageListLargeRed;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBgRed;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBgBlue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIcons;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLargeRed;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLargeBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRemoveItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSmallRed;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSmallBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonScreenSave;
        private System.Windows.Forms.Timer timercpu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarCpu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCPU;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

