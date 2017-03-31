using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;//
using System.Drawing.Drawing2D;//
using System.Threading;//
using System.Runtime.InteropServices;//
using System.Xml;//
using System.IO;//



namespace WinListViewQQ
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 组标志参数
        /// </summary>
        private int  btnFlag =0;
        ListView listView1 = new ListView();
        PerformanceCounter p = new PerformanceCounter();

        public frmMain()
        {
            InitializeComponent();
          
            p.CounterName =@"% Processor Time"; //@"% Committed Bytes In Use";
            p.CategoryName = "Processor";//"Memory";
            p.InstanceName = "_Total";
 
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
              InitialFrmMain();//调方法初始化主窗体
              //
              InitialListView();//调方法初始化ListView
             //
              btnOne_Click(sender, e);
       
              string fileName = Application.StartupPath + "\\config.xml";
            
              if (!File.Exists(fileName))
              {
                 clsXMl.CreateXmlConfigFile();//如果不存在配置文件，则创建
                 ReadXmlConfigFile(fileName);

                 fileName = null;
                 GC.Collect();
              }
              else 
              {
                  ReadXmlConfigFile(fileName);//如果存在配置文件,则读取

                  fileName = null;
                  GC.Collect();
              }   
           
        }

        /// <summary>
        /// 初始化主窗体相关
        /// </summary>
        private void InitialFrmMain()
        {
            contextMenuStripTaskbar.AutoClose = true;
            contextMenuStripListView.AutoClose = true;
            this.ContextMenuStrip = contextMenuStripTaskbar;
            //图片存放的相对路径         
            string strImagePath = Application.StartupPath.Substring(0 ) + "\\images";//**************************************************
            //设置窗体图标
           this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(strImagePath + "\\ico.ico");
            //初始化ImageList图片集
           // for (int i = 0; i < 1; i++)
            //{
                imageListSmallBlue.Images.Add("0", Image.FromFile(strImagePath + "\\smallBlue.bmp"));//
           // }
            for(int j=0;j<1;j++)
            {
                imageListLargeBlue.Images.Add(j.ToString(), Image.FromFile(strImagePath + "\\largeBlue.bmp"));
            }
            for (int j = 0; j < 1; j++)
            {
                imageListLargeRed.Images.Add(j.ToString(), Image.FromFile(strImagePath + "\\largeRed.bmp"));
            }
            for (int j = 0; j <1; j++)
            {
                imageListSmallRed.Images.Add(j.ToString(), Image.FromFile(strImagePath + "\\smallRed.bmp"));
            }

            //设置菜单图标
            toolStripButtonShowDesktopIcon.Image = Image.FromFile(strImagePath + "\\desktop.png");
            toolStripButtonExit.Image=Image.FromFile(strImagePath+"\\exit.ico");
            //设置右键菜单图标
            ToolStripMenuItemShowDeskTopIco.Image = Image.FromFile(strImagePath + "\\desktop.png");
            ToolStripMenuItemShowFrmMain.Image= Image.FromFile(strImagePath + "\\showFrmMain.ico");
            //初始化窗体大小
            this.Width = 171;
            this.Height = 500;
            //初始化窗体位置
            this.Top = 40; ;
            this.Left = Screen.PrimaryScreen.Bounds.Width - 400;
            //
            this.ShowInTaskbar = false;                     
        }
      
        /// <summary>
        /// 窗体加载  初始化ListView的方法
        /// </summary>
        private void InitialListView()
        {
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDown += new MouseEventHandler(this.listView1_MouseDown);// (object sender, MouseEventArgs e)

            splitContainer1.Panel2.Controls.Add(listView1);
            listView1.MultiSelect = false;
            listView1.FullRowSelect = true;
            
            listView1.BackgroundImageTiled = true;
            //listView1.Sorting = SortOrder.Ascending;
            listView1.HideSelection = false;
            listView1.Dock = DockStyle.Fill;
            
            //---------------------------------------
            listView1.Clear(); 
          
            listView1.Dock = DockStyle.Fill;

            btnOne.Dock = DockStyle.Top;
            btnTwo.Dock = DockStyle.Top;
            btnThree.Dock = DockStyle.Top;
            btnFour.Dock = DockStyle.Top;

            listView1.LargeImageList = imageListSmallBlue;

            listView1.ContextMenuStrip = contextMenuStripListView;
            contextMenuStripListView.Items[0].Enabled = false;//int
            contextMenuStripListView.Items["ToolStripMenuItemRemoveItem"].Enabled = false;//name  
  
        }

        /// <summary>
        /// 窗体加载 读取 配置文件的参数设置
        /// </summary>
        /// <param name="fileName">文件路径+名</param>
        private void ReadXmlConfigFile(string fileName)
        {
            
            XmlNode root = clsXMl.GetRootNode();
           
            foreach (XmlNode node in root.ChildNodes)
            {  
                switch (node.Name)
                {
                    case "TopMost":
                                    switch (node.InnerText.Trim())
                                    {
                                        case "no":
                                            this.TopMost = false;
                                            ToolStripMenuItemTopMost.Checked = false;
                                            break;
                                        case "yes":
                                            this.TopMost = true;
                                            ToolStripMenuItemTopMost.Checked = true;
                                            break;
                                    };
                                    break;
                    case "AutoRun":
                                    switch (node.InnerText.Trim())
                                    {
                                        case"no":
                                            ToolStripMenuItemAutoRun.Checked = false;
                                            break;
                                        case"yes":
                                            ToolStripMenuItemAutoRun.Checked = true;
                                            break;
                                    }
                                    break;
                    case"BgImage":
                        switch(node.InnerText.Trim())
                        {
                            case "blue":
                                listView1.BackgroundImage = Image.FromFile(Application.StartupPath.Substring(0) + "\\images" + "\\bgBlue.jpg");
                                ToolStripMenuItemBgRed.Checked =false ;
                                ToolStripMenuItemBgBlue.Checked = true;
                                     break;
                            case"red":
                                listView1.BackgroundImage = Image.FromFile(Application.StartupPath.Substring(0) + "\\images" + "\\bgRed.jpg");
                                ToolStripMenuItemBgRed.Checked = true;
                                ToolStripMenuItemBgBlue.Checked = false;
                                break;
                        }
                        break;  
                    case "Icon":
                        switch (node.InnerText.Trim())
                        {
                            case "blue":
                                if (node.Attributes["size"].Value == "small")
                                {
                                    listView1.LargeImageList = imageListSmallBlue;

                                    ToolStripMenuItemLargeBlue.Checked = false;
                                    ToolStripMenuItemLargeRed.Checked = false;
                                    ToolStripMenuItemSmallRed.Checked = false;
                                    ToolStripMenuItemSmallBlue.Checked = true;
                                    return;                               
                                }
                                else if (node.Attributes["size"].Value == "large")
                                {
                                    listView1.LargeImageList = imageListLargeBlue;

                                    ToolStripMenuItemLargeBlue.Checked = true;
                                    ToolStripMenuItemLargeRed.Checked = false;
                                    ToolStripMenuItemSmallRed.Checked = false;
                                    ToolStripMenuItemSmallBlue.Checked = false;
                                    return;  
                                }

                                break;
                            case "red":
                                if (node.Attributes["size"].Value== "small")
                                {
                                    listView1.LargeImageList = imageListSmallRed;

                                    ToolStripMenuItemLargeBlue.Checked = false;
                                    ToolStripMenuItemLargeRed.Checked = false;
                                    ToolStripMenuItemSmallRed.Checked =true ;
                                    ToolStripMenuItemSmallBlue.Checked = false;
                                    return;  
                                }
                                else if (node.Attributes["size"].Value == "large")
                                {
                                    listView1.LargeImageList = imageListLargeRed;

                                    ToolStripMenuItemLargeBlue.Checked = false;
                                    ToolStripMenuItemLargeRed.Checked = true;
                                    ToolStripMenuItemSmallRed.Checked = false;
                                    ToolStripMenuItemSmallBlue.Checked = false;
                                    return;  
                                }
                                break;
                        }
                       
                        break;
                        

                        

                }
            }   

        }
       
     
 //-----------------------------------------------------------------------------------------------------------------------------   
 //-----------------------------------------------------------------------------------------------------------------------------     
           
        private void btnOne_Click(object sender, EventArgs e)
        {
            btnFlag = 1;//修改组标志
            //
            listView1.Dock = DockStyle.None;
            
            btnOne.Dock = DockStyle.Top;

            btnTwo.Dock = DockStyle.Bottom;

            btnThree.SendToBack();
            btnThree.Dock = DockStyle.Bottom;

            btnFour.SendToBack();
            btnFour.Dock = DockStyle.Bottom;

            statusStrip1.SendToBack();
            statusStrip1.Dock = DockStyle.Bottom;
            //
            listView1.BringToFront();
            listView1.Dock = DockStyle.Fill;
            listView1.Clear();          
            //
            InitialAddItem(btnFlag);
         
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
             btnFlag = 2;//修改组标志
             listView1.Dock = DockStyle.None;
            //
            btnTwo.Dock = DockStyle.Top;

            btnOne.SendToBack();
            btnOne.Dock = DockStyle.Top;

            btnThree.Dock = DockStyle.Bottom;

            btnFour.SendToBack();
            btnFour.Dock = DockStyle.Bottom;

            statusStrip1.SendToBack();
            statusStrip1.Dock = DockStyle.Bottom;

           
            //
           
            listView1.Dock = DockStyle.Fill;
           
            listView1.Clear();
            //
            InitialAddItem(btnFlag);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            btnFlag = 3;
           listView1.Dock = DockStyle.None;
            //
            btnThree.SendToBack();
            btnThree.Dock = DockStyle.Top;

            btnTwo.SendToBack();
            btnTwo.Dock = DockStyle.Top;

            btnOne.SendToBack();
            btnOne.Dock = DockStyle.Top;

            btnFour.SendToBack();
            btnFour.Dock = DockStyle.Bottom;

            statusStrip1.SendToBack();
            statusStrip1.Dock = DockStyle.Bottom;
          
            //
            listView1.BringToFront();
            listView1.Dock = DockStyle.Fill;
            listView1.Clear();        
            //
            InitialAddItem(btnFlag);
            
        }


        private void btnFour_Click(object sender, EventArgs e)
        {
            btnFlag = 4;

            listView1.Dock = DockStyle.None;
            btnFour.SendToBack();
            btnFour.Dock = DockStyle.Top;

            btnThree.SendToBack();
            btnThree.Dock = DockStyle.Top;
           
            btnTwo.SendToBack();
            btnTwo.Dock = DockStyle.Top;

            btnOne.SendToBack();
            btnOne.Dock = DockStyle.Top;
         
            listView1.BringToFront();
            listView1.Dock = DockStyle.Fill;
            listView1.Items.Clear();
         
            //
            InitialAddItem(btnFlag);  

        }
        private void btnOne_MouseEnter(object sender, EventArgs e)
        {

            this.btnOne.BackColor = Color.LightSeaGreen;

        }

        private void btnOne_MouseLeave(object sender, EventArgs e)
        {

            this.btnOne.BackColor = Control.DefaultBackColor;
        }

        private void btnTwo_MouseEnter(object sender, EventArgs e)
        {
            this.btnTwo.BackColor = Color.LightSeaGreen;
        }

        private void btnTwo_MouseLeave(object sender, EventArgs e)
        {

            this.btnTwo.BackColor = Control.DefaultBackColor;
        }

        private void btnThree_MouseEnter(object sender, EventArgs e)
        {
            this.btnThree.BackColor = Color.LightSeaGreen;
        }

        private void btnThree_MouseLeave(object sender, EventArgs e)
        {

            this.btnThree.BackColor = Control.DefaultBackColor;
        }
   //-------------------------------------------------------------------------------------------------------------
  //------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 加载项的方法
        /// </summary>
        /// <param name="btnFlag">分组标志</param>
        private void InitialAddItem(int btnFlag)
        {
            string key = null;
            string text = null;
            int imageIndex = 0;
            XmlNode root = clsXMl.GetRootNode();
          
           
            int i=0;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "Item" && node.FirstChild.InnerText == btnFlag.ToString())
                {
                    key = node.ChildNodes[1].InnerText.ToString();
                    text = node.ChildNodes[2].InnerText.ToString();
                    imageIndex = Convert.ToInt32(node.ChildNodes[3].InnerText.ToString());
                    //
                    ListViewItem item = new ListViewItem();
                    item.Tag = (object)key;//-----------------
                    item.Text = text;
                    item.ImageIndex = imageIndex;
                    //

                    listView1.Items.Add(item);

                }
 
            }

        }

   #region 处理双击打开项的事件

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {  

            ListViewItem itemSelected = null; // itemSelected = listView1.GetItemAt(e.X, e.Y);
       
            itemSelected = listView1.FocusedItem;
         
            if (itemSelected != null && e.Clicks > 1)// double-click 
            {
                DoItem(itemSelected);
                itemSelected = null;
                GC.Collect();

            }
        }
#endregion

        /// <summary>
        /// 处理打开 项的方法
        /// </summary>
        /// <param name="itemSelected"></param>
        private void DoItem(ListViewItem itemSelected)
        {
            try
            {
                switch (itemSelected.Text)
                {
                    default:
                        Process.Start(itemSelected.Tag.ToString());
                        break;

                }
            }
            catch
            {
                MessageBox.Show("选中项无效");
            }

        }


   #region   双击notifyIcon事件
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {

            ShowFrmMain();
        }
        #endregion

        /// <summary>
       /// 显示主窗体的方法
       /// </summary>
        private void  ShowFrmMain()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;

                this.Top = 40; ;
                this.Left = Screen.PrimaryScreen.Bounds.Width - 400;

                this.Activate();

            }
        }

        /// <summary>
        /// 保存主窗体TopMost设置的方法
        /// </summary>
        private void DoTopMostXML()
        {
            XmlNode root = clsXMl.GetRootNode();
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "TopMost")
                {
                    if (node.InnerText == "yes")
                    {
                        node.InnerText = "no";
                        this.TopMost = false;
                        ToolStripMenuItemTopMost.Checked = false;
                    }
                    else if (node.InnerText == "no")
                    {
                        node.InnerText = "yes";
                        this.TopMost = true;
                        ToolStripMenuItemTopMost.Checked = true;
                    }

                }
            }
            clsXMl.xmlSave();//save the config file
          
            root = null;
        }
 
        /// <summary>
        /// 保存开启启动设置的方法
        /// </summary>
        private void DoAutoRunXML()
        {
            XmlNode root = clsXMl.GetRootNode();
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "AutoRun")
                {
                    if (node.InnerText == "no")
                    {
                        node.InnerText = "yes";//重写ＸＭＬ
                        ToolStripMenuItemAutoRun.Checked = true;
                        RunWhenStart(true, Application.ProductName, Application.StartupPath + "\\" + Application.ProductName + ".exe");
                    }
                    else if (node.InnerText == "yes")
                    {
                        node.InnerText = "no";
                        ToolStripMenuItemAutoRun.Checked = false;
                        RunWhenStart(false, Application.ProductName, Application.StartupPath + "\\" + Application.ProductName + ".exe");

                    } 
                    clsXMl.xmlSave();
                    return;
                }
                
            }

          
          
        }

        /// <summary>
        /// 修改 开机启动 注册表的方法
        /// </summary>
        /// <param name="bFlag"> 是否开机启动</param>
        /// <param name="strName">启动值的名称</param>
        /// <param name="strPath">启动程序的路径</param>
        private void RunWhenStart(bool bFlag, string strName, string strPath)
        {
            Microsoft.Win32.RegistryKey rootKey = Microsoft.Win32.Registry.LocalMachine;//本地计算机数据的配置
            Microsoft.Win32.RegistryKey runKey = rootKey.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");

            if (bFlag == true)//创建开机启动
            {
                try
                {
                    runKey.SetValue(strName, strPath);
                    rootKey.Close();// 刷新 关闭 保存修改 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " 提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    runKey.DeleteValue(strName);
                    rootKey.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " 提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        [DllImport("user32.dll")]
        private static extern int SendMessageA(int hWnd, int Msg, int wParam, int lParam);

        private const int HWND_BROADCAST = 0xffff;
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_SCREENSAVE = 0xf140;

  #region  开启屏保事件  
        private void toolStripButtonScreenSave_Click(object sender, EventArgs e)
        {
            SendMessageA(HWND_BROADCAST, WM_SYSCOMMAND, SC_SCREENSAVE, 0);

        }
    #endregion

  #region       处理桌面图标 事件
        private void toolStripButtonShowDesktopIcon_Click(object sender, EventArgs e)
        {
            ShowOrHideDeskTopIcos();
        }
 #endregion
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(int hWnd, int cmdShow);

        /// <summary>
        /// 处理桌面图标显示或隐藏的方法
        /// </summary>
        private void  ShowOrHideDeskTopIcos()
        {
            int h = FindWindow("Progman", null);
            switch (toolStripButtonShowDesktopIcon.Text)
            {
                case "隐藏桌面图标":
                    toolStripButtonShowDesktopIcon.Text = "显示桌面图标";
                    toolStripButtonShowDesktopIcon.ToolTipText = "显示桌面图标";
                    ToolStripMenuItemShowDeskTopIco.Text = "显示桌面图标";
                    ShowWindow(h, 0);
                    break;
                case "显示桌面图标":
                    toolStripButtonShowDesktopIcon.Text = "隐藏桌面图标";
                    toolStripButtonShowDesktopIcon.ToolTipText = "隐藏桌面图标";
                    ToolStripMenuItemShowDeskTopIco.Text = "隐藏桌面图标";
                    ShowWindow(h, 1);
                    break;

            }
        }

       
  #region 单击X 或alt+F4 隐藏窗体
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();//隐藏窗体
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }

        }
      #endregion

  #region 窗体Resize事件　最小化则隐藏窗体
        private void Form1_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)//窗口状态为最小化时 

                this.Hide();//隐藏窗口 

        }
        #endregion

        /// <summary>
        /// 退出主窗体 方法
        /// </summary>
        private void FrmMainExit()
        {
            if (MessageBox.Show("你真要退出吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                notifyIcon1.Visible = false;
                Application.Exit();
                this.Dispose();
            }
        }

       
  #region　工具栏按钮单击事件 退出程序
        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
            this.Dispose();
        }
        #endregion

          
  #region　listview选中项发生变化所引发的事件
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                contextMenuStripListView.Items[0].Enabled = true;
                contextMenuStripListView.Items["ToolStripMenuItemRemoveItem"].Enabled = true;
            }
            else//未选中项
            {
                contextMenuStripListView.Items[0].Enabled = false;
                contextMenuStripListView.Items["ToolStripMenuItemRemoveItem"].Enabled = false;

            }
        }
    #endregion

        
  #region contextMenuStripListView菜单的打开程序事件
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            DoItem(listView1.FocusedItem);
        }
 #endregion
      
       
  #region contextMenuStripTaskbar背景绘制
        private void contextMenuStripTaskbar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color FColor = Color.LightGreen;
            Color TColor = Color.MediumPurple;
            Brush b = new LinearGradientBrush(this.contextMenuStripTaskbar.ClientRectangle, FColor, TColor, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, this.contextMenuStripTaskbar.ClientRectangle);
        }
 #endregion

  #region 设置为红色背景  
        private void ToolStripMenuItemBgBlue_Click(object sender, EventArgs e)
        {
            string strImagePath = Application.StartupPath.Substring(0) + "\\images";
            this.listView1.BackgroundImage = Image.FromFile(strImagePath + "\\bgBlue.jpg");
            ToolStripMenuItemBgRed.Checked = false;
            ToolStripMenuItemBgBlue.Checked =true ;
            foreach(XmlNode node in clsXMl.GetRootNode())
            {
                if (node.Name =="BgImage")
                {
                    if (node.InnerText != "blue")
                    {
                        node.InnerText = "blue";
                    }
                    else
                    {
                        return;
                    }
                }
                return;
                
            }
            clsXMl.xmlSave();
            strImagePath = null;
          　
        }
 #endregion

  #region 设置为蓝色背景
        private void ToolStripMenuItemBgRed_Click(object sender, EventArgs e)
        {　　
            string strImagePath = Application.StartupPath.Substring(0) + "\\images";
            this.listView1.BackgroundImage = Image.FromFile(strImagePath + "\\bgRed.jpg");
            ToolStripMenuItemBgRed.Checked = true;
            ToolStripMenuItemBgBlue.Checked = false;

            foreach (XmlNode node in clsXMl.GetRootNode())
            {
                if (node.Name == "BgImage")
                {
                    if (node.InnerText != "red")
                    {
                        node.InnerText = "red";
                    }
                    else
                    {
                        return;
                    }
                }
                return;

            }
            clsXMl.xmlSave();

            strImagePath = null;

        }
 #endregion

       
  #region  红色 大图标
        private void ToolStripMenuItemLargeRed_Click(object sender, EventArgs e)
        {
            listView1.LargeImageList = imageListLargeRed;
            ToolStripMenuItemLargeBlue.Checked = false;
            ToolStripMenuItemLargeRed.Checked = true;
            ToolStripMenuItemSmallRed.Checked = false;
            ToolStripMenuItemSmallBlue.Checked = false;
            foreach (XmlNode node in clsXMl.GetRootNode().ChildNodes)
            {
                if (node.Name == "Icon")
                {
                       
                        if (node.InnerText.Trim() == "blue")
                        {
                            node.InnerText = "red";
                        }
                    

                        if (node.Attributes["size"].Value == "small")
                        {
                            XmlElement xe = (XmlElement)node;
                            xe.SetAttribute("size", "large");
                        }
                        else if ((node.Attributes["size"].Value == "large"))
                        {
                            return;
                        }
                  
                   
                }
                return;
            }
            clsXMl.xmlSave();

        }
  #endregion

  #region 蓝色大图标
        private void ToolStripMenuItemLargeBlue_Click(object sender, EventArgs e)
        {
           
            listView1.LargeImageList = imageListLargeBlue;
            ToolStripMenuItemLargeBlue.Checked = true;
            ToolStripMenuItemLargeRed.Checked = false;
            ToolStripMenuItemSmallRed.Checked = false;
            ToolStripMenuItemSmallBlue.Checked = false;
            foreach (XmlNode node in clsXMl.GetRootNode())
            {
                if (node.Name == "Icon")
                {

                    if (node.InnerText.Trim() == "red")
                    {
                        node.InnerText = "blue";
                    }


                    if (node.Attributes["size"].Value == "small")
                    {
                        XmlElement xe = (XmlElement)node;
                        xe.SetAttribute("size", "large");
                    }
                    else if ((node.Attributes["size"].Value == "large"))
                    {
                        return;
                    }


                }
                return;
            }
            clsXMl.xmlSave();

        }
 #endregion

  #region 红色 小图标
        private void ToolStripMenuItemSmallRed_Click_1(object sender, EventArgs e)
        {
            listView1.LargeImageList = imageListSmallRed;
            ToolStripMenuItemLargeBlue.Checked = false;
            ToolStripMenuItemLargeRed.Checked = false;
            ToolStripMenuItemSmallRed.Checked = true;
            ToolStripMenuItemSmallBlue.Checked = false;
            foreach (XmlNode node in clsXMl.GetRootNode())
            {
                if (node.Name == "Icon")
                {

                    if (node.InnerText.Trim() == "blue")
                    {
                        node.InnerText = "red";
                    }


                    if (node.Attributes["size"].Value == "large")
                    {
                        XmlElement xe = (XmlElement)node;
                        xe.SetAttribute("size", "small");
                    }
                    else if ((node.Attributes["size"].Value == "small"))
                    {
                        return;
                    }

                }
                return;
            }
            clsXMl.xmlSave();
        }
#endregion

  #region 蓝色 小图标
        private void ToolStripMenuItemSmallBlue_Click(object sender, EventArgs e)
        {
         listView1.LargeImageList = imageListSmallBlue;
         ToolStripMenuItemLargeBlue.Checked = false;
         ToolStripMenuItemLargeRed.Checked = false;
         ToolStripMenuItemSmallRed.Checked = false;
         ToolStripMenuItemSmallBlue.Checked = true;
         foreach (XmlNode node in clsXMl.GetRootNode())
         {
             if (node.Name == "Icon")
             {

                 if (node.InnerText.Trim() == "red")
                 {
                     node.InnerText = "blue";
                 }


                 if (node.Attributes["size"].Value == "large")
                 {
                     XmlElement xe = (XmlElement)node;
                     xe.SetAttribute("size", "small");
                 }
                 else if ((node.Attributes["size"].Value == "small"))
                 {
                     return;
                 }
             }
             return;
         }
         clsXMl.xmlSave();
     }
#endregion
       
 #region  contextMenuStripListView 添加项 事件  
        private void ToolStripMenuItemAddItem_Click(object sender, EventArgs e)
        {               
                   frmAddItem f2 = new frmAddItem();
                                   
                    f2.Intflag= btnFlag;//
                    f2.ShowDialog();
  
                    string[] arrStr = f2.ItemInfo.Split('|');

                    if (arrStr.Length > 2)
                    {
                        ListViewItem item = new ListViewItem();

                        item.Tag = (object)arrStr[0];//key 
                        item.Text = arrStr[1]; //text
                        item.ImageIndex = int.Parse(arrStr[2]);//imageIndex

                        listView1.Items.Add(item);
                           
                    }

                }
 #endregion
                
  #region  绘制背景
        private void contextMenuStrip2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color FColor = Color.LightGreen;
            Color TColor = Color.MediumPurple;
            Brush b = new LinearGradientBrush(this.contextMenuStripListView.ClientRectangle, FColor, TColor, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, this.contextMenuStripListView.ClientRectangle);
        }
  #endregion

  #region     右键菜单contextMenuStripTaskbar的单击响应处理

        private void contextMenuStripTaskbar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    switch (e.ClickedItem.Name)
                    {
                        case "ToolStripMenuItemShowFrmMain":
                            ShowFrmMain();
                            break;

                        case "ToolStripMenuItemShowDeskTopIco":
                            ShowOrHideDeskTopIcos();
                            break;

                        case "ToolStripMenuItemAutoRun":
                            DoAutoRunXML();
                            break;

                        case "ToolStripMenuItemTopMost":
                            DoTopMostXML();
                            break;
                        case "ToolStripMenuItemAbout":
                            MessageBox.Show("create by myh65013\nmsproject@live.com");
                            break;

                        case "ToolStripMenuItemExit":
                            FrmMainExit();
                            break;  
                }
            }
   #endregion
       
  #region   移除项
        private void ToolStripMenuItemRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listView1.FocusedItem;
                listView1.Items.Remove(item);
                foreach (XmlNode node in clsXMl.GetRootNode().ChildNodes)
                {

                    if (node.Name == "Item")
                    {
                        if (node.FirstChild.NextSibling.InnerText == item.Tag.ToString())
                        {

                            try
                            {
                                node.ParentNode.RemoveChild(node);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }


                    }
                }
            }
            catch 
            {
                MessageBox.Show("没有选中项");
            }
            clsXMl.xmlSave();
        }
     #endregion

  #region timer事件
        private void timercpu_Tick(object sender, EventArgs e)
        {
            
            toolStripProgressBarCpu.Value = (int)(p.NextValue());
            toolStripStatusLabelCPU.Text = toolStripProgressBarCpu.Value.ToString() + "%";


        }
    #endregion













    }
}