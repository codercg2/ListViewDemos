using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestDrag
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private DragNDrop.DragAndDropListView listView1;
		private DragNDrop.DragAndDropListView listView2;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			LoadInfo();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.listView1 = new DragNDrop.DragAndDropListView();
			this.listView2 = new DragNDrop.DragAndDropListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.AllowDrop = true;
			this.listView1.AllowReorder = true;
			this.listView1.LargeImageList = this.imageList1;
			this.listView1.LineColor = System.Drawing.Color.Red;
			this.listView1.Location = new System.Drawing.Point(8, 8);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(272, 96);
			this.listView1.TabIndex = 0;
			// 
			// listView2
			// 
			this.listView2.AllowDrop = true;
			this.listView2.AllowReorder = true;
			this.listView2.LargeImageList = this.imageList1;
			this.listView2.LineColor = System.Drawing.Color.Red;
			this.listView2.Location = new System.Drawing.Point(8, 112);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(272, 96);
			this.listView2.TabIndex = 1;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 219);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form2";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form2";
			this.ResumeLayout(false);

		}
		#endregion

		private void LoadInfo()
		{
			listView1.Items.Add("Item 1-1", 0);
			listView1.Items.Add("Item 1-2", 1);
			listView1.Items.Add("Item 1-3", 2);

			listView2.Items.Add("Item 2-1", 0);
			listView2.Items.Add("Item 2-2", 1);
			listView2.Items.Add("Item 2-3", 2);
		}
	}
}
