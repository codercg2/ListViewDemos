using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinListViewQQ
{ 
    public partial class frmAddItem : Form
    {
        private string itemInfo = string.Empty;//保存项的key,text,imageIndex信息
        /// <summary>
        /// 保存项的key,text,imageIndex信息
        /// </summary>
        public string ItemInfo
        {
            get { return itemInfo; }
            set { itemInfo = value; }
        }

        private int intflag;//组标志
        /// <summary>
        /// 组标志位
        /// </summary>
        public int Intflag
        {
            get { return intflag; }
            set { intflag = value; }
        }

    


        public frmAddItem()
        {
            InitializeComponent();

            //图片存放的相对路径         
            string strImagePath = Application.StartupPath.Substring(0) + "\\images";//**************************************************
            //设置窗体图标
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(strImagePath + "\\ico.ico");
          
            
        }
        /// <summary>
        /// 选择程序路径+名 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtPath.Text = dlg.FileName.ToString().Trim();
             txtInfo.Text=txtPath.Text.Substring(txtPath.Text.LastIndexOf('\\')+1);
        }
      
      #region 添加项 按钮事件
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string key=txtPath.Text;//键
            if (key.Length < 0 || !key.EndsWith("exe"))
            {
                MessageBox.Show("请输入完整的程序路径");
                return;
            }
            string text=string.Empty;
            int imageIndex=0;
            if (txtInfo.Text.Trim() == "")
            {
                text = key.Substring(key.LastIndexOf('\\') + 1);//值
            }
            else
            {
                text = txtInfo.Text.Trim();
            }
   
            //

           clsXMl.AddXmlNode(key,text,imageIndex,Intflag);
           //
            itemInfo = key + "|" + text + "|" + imageIndex.ToString();
            MessageBox.Show("ok");

            this.Close();
            this.Dispose();
            return;

        }
   #endregion

        #region 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion




    }
}