using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;//

namespace WinListViewQQ
{
    class clsXMl
    {
        private  static XmlDocument xmlDoc = new XmlDocument();
        static string fileName =System.Windows.Forms.Application.StartupPath + "\\config.xml";//配置文件的路径、名

        
        /// <summary>
        /// 返回xml文档的根节点
        /// </summary>
        /// <returns>根节点</returns>
        public static XmlNode GetRootNode()
        {
            //xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);
            XmlNode root = xmlDoc.DocumentElement;
            return root;

        }
        /// <summary>
        ///  保存XML文件
        /// </summary>
       
        public static void xmlSave()
        {
            xmlDoc.Save(fileName);
        }
    

        /// <summary>
        /// 创建节点（默认配置文件）
        /// </summary>
       
        public static void CreateXmlConfigFile()
        {

            XmlTextWriter xmlWriter;
            xmlWriter = new XmlTextWriter(fileName, Encoding.Default);//creat            //string fileName = Application.StartupPath + "\\config.xml";
            xmlWriter.Formatting = Formatting.Indented;//自动缩进格式

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Root");
            //
                xmlWriter.WriteStartElement("TopMost");
                xmlWriter.WriteString("yes");
                xmlWriter.WriteEndElement();
                //
                xmlWriter.WriteStartElement("AutoRun");
                xmlWriter.WriteString("no");
                xmlWriter.WriteEndElement();
                //
                xmlWriter.WriteStartElement("BgImage");
                xmlWriter.WriteString("blue");
                xmlWriter.WriteEndElement();
              //
                xmlWriter.WriteStartElement("Icon");
                xmlWriter.WriteAttributeString("size", "small");
                xmlWriter.WriteString("blue");
                xmlWriter.WriteEndElement();  
              
            //
            xmlWriter.WriteEndElement();

            xmlWriter.Close();
           AddXmlNode("::{20D04FE0-3AEA-1069-A2D8-08002B30309D}", "我的电脑", 0, 1);
           AddXmlNode("shell:ControlPanelFolder","控制面板",0,1);
           AddXmlNode("regedit.exe","注册表",0,1);
           AddXmlNode("Msconfig.exe","系统配置信息",0,1);
           AddXmlNode("perfmon.msc","计算机性能监测",0,1);
           AddXmlNode("compmgmt.msc","计算机管理",0,1);
           AddXmlNode("Nslookup","IP地址侦测",0,1);
           AddXmlNode("fsmgmt.msc","共享文件管理",0,1); 
            //
           AddXmlNode("IEXPLORE.EXE","IE",0,2);
           AddXmlNode("wmplayer.exe","MediaPlay",0,2);
           AddXmlNode("calc","计算器",0,2);
           AddXmlNode("mspaint", "画图板", 0, 2);
          ;
           
            
                   

            xmlWriter = null;
            GC.Collect();
        }
       /// <summary>
        /// 创建节点
       /// </summary>
        /// <param name="key">路径+程序名</param>
        /// <param name="text">描述</param>
        /// <param name="imageIndex">图标</param>
       /// <param name="flag">组标志</param>
        public static void AddXmlNode(string key,string text, int imageIndex,int flag)
        {
           XmlNode root= GetRootNode();

           XmlElement xe = xmlDoc.CreateElement("Item");
            //---
               XmlElement xeFlag = xmlDoc.CreateElement("flag");
               xeFlag.InnerText = flag.ToString();
               xe.AppendChild(xeFlag);
            //
                XmlElement xeKey = xmlDoc.CreateElement("key");
                xeKey.InnerText = key;
                xe.AppendChild(xeKey);
                //
                XmlElement xeText = xmlDoc.CreateElement("text");
                xeText.InnerText = text;
                xe.AppendChild(xeText);
                //
                XmlElement xeImageIndex = xmlDoc.CreateElement("imageIndex");
                xeImageIndex.InnerText=imageIndex.ToString();
                xe.AppendChild(xeImageIndex);
                //
               

           //---
           root.AppendChild(xe);


           xmlSave();

        }
    }
}
