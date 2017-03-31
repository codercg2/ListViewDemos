using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TestDrag
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private DragNDrop.DragAndDropListView DragAndDropListView1;
		private DragNDrop.DragAndDropListView DragAndDropListView2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
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
				if (components != null) 
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
			this.DragAndDropListView1 = new DragNDrop.DragAndDropListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.DragAndDropListView2 = new DragNDrop.DragAndDropListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// DragAndDropListView1
			// 
			this.DragAndDropListView1.AllowDrop = true;
			this.DragAndDropListView1.AllowReorder = true;
			this.DragAndDropListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.DragAndDropListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																								   this.columnHeader1,
																								   this.columnHeader2});
			this.DragAndDropListView1.FullRowSelect = true;
			this.DragAndDropListView1.LineColor = System.Drawing.Color.LightGray;
			this.DragAndDropListView1.Location = new System.Drawing.Point(8, 8);
			this.DragAndDropListView1.Name = "DragAndDropListView1";
			this.DragAndDropListView1.Size = new System.Drawing.Size(456, 152);
			this.DragAndDropListView1.TabIndex = 0;
			this.DragAndDropListView1.View = System.Windows.Forms.View.List;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 190;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Width = 244;
			// 
			// DragAndDropListView2
			// 
			this.DragAndDropListView2.AllowDrop = true;
			this.DragAndDropListView2.AllowReorder = true;
			this.DragAndDropListView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.DragAndDropListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																								   this.columnHeader3,
																								   this.columnHeader4});
			this.DragAndDropListView2.FullRowSelect = true;
			this.DragAndDropListView2.LineColor = System.Drawing.Color.Red;
			this.DragAndDropListView2.Location = new System.Drawing.Point(8, 168);
			this.DragAndDropListView2.Name = "DragAndDropListView2";
			this.DragAndDropListView2.Size = new System.Drawing.Size(456, 152);
			this.DragAndDropListView2.TabIndex = 1;
			this.DragAndDropListView2.View = System.Windows.Forms.View.List;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Width = 190;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Width = 244;
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 331);
			this.Controls.Add(this.DragAndDropListView2);
			this.Controls.Add(this.DragAndDropListView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form3";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form3";
			this.ResumeLayout(false);

		}
		#endregion

		private void LoadInfo()
		{
			DragAndDropListView1.Items.Add(new ListViewItem(new string[2] {"Item One", "List View 1"}));
			DragAndDropListView1.Items.Add(new ListViewItem(new string[2] {"Item Two", "List View 1"}));
			DragAndDropListView1.Items.Add(new ListViewItem(new string[2] {"Item Three", "List View 1"}));
			DragAndDropListView1.Items.Add(new ListViewItem(new string[2] {"Item Four", "List View 1"}));
			DragAndDropListView1.Items.Add(new ListViewItem(new string[2] {"Item Five", "List View 1"}));

			DragAndDropListView2.Items.Add(new ListViewItem(new string[2] {"Item One", "List View 2"}));
			DragAndDropListView2.Items.Add(new ListViewItem(new string[2] {"Item Two", "List View 2"}));
			DragAndDropListView2.Items.Add(new ListViewItem(new string[2] {"Item Three", "List View 2"}));
			DragAndDropListView2.Items.Add(new ListViewItem(new string[2] {"Item Four", "List View 2"}));
			DragAndDropListView2.Items.Add(new ListViewItem(new string[2] {"Item Five", "List View 2"}));
		}
	}
}
