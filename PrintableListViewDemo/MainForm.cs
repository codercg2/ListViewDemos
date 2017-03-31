using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestPritableListView
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private PrintableListView.PrintableListView m_list;
		private System.Windows.Forms.Button m_btnPrintPreview;
		private System.Windows.Forms.Button m_btnPrint;
		private System.Windows.Forms.Button m_btnPageSetup;
		private System.Windows.Forms.Button m_btnExit;
		private System.Windows.Forms.CheckBox m_cbFitToPage;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.m_list = new PrintableListView.PrintableListView();
			this.m_btnPrintPreview = new System.Windows.Forms.Button();
			this.m_btnPrint = new System.Windows.Forms.Button();
			this.m_btnPageSetup = new System.Windows.Forms.Button();
			this.m_btnExit = new System.Windows.Forms.Button();
			this.m_cbFitToPage = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// m_list
			// 
			this.m_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.m_list.FitToPage = false;
			this.m_list.FullRowSelect = true;
			this.m_list.Location = new System.Drawing.Point(16, 64);
			this.m_list.Name = "m_list";
			this.m_list.Size = new System.Drawing.Size(632, 312);
			this.m_list.TabIndex = 4;
			this.m_list.Title = "";
			this.m_list.View = System.Windows.Forms.View.Details;
			// 
			// m_btnPrintPreview
			// 
			this.m_btnPrintPreview.Location = new System.Drawing.Point(128, 24);
			this.m_btnPrintPreview.Name = "m_btnPrintPreview";
			this.m_btnPrintPreview.Size = new System.Drawing.Size(96, 23);
			this.m_btnPrintPreview.TabIndex = 1;
			this.m_btnPrintPreview.Text = "Print Preview";
			this.m_btnPrintPreview.Click += new System.EventHandler(this.ButtonPrintPreview_OnClick);
			// 
			// m_btnPrint
			// 
			this.m_btnPrint.Location = new System.Drawing.Point(240, 24);
			this.m_btnPrint.Name = "m_btnPrint";
			this.m_btnPrint.Size = new System.Drawing.Size(96, 23);
			this.m_btnPrint.TabIndex = 2;
			this.m_btnPrint.Text = "Print";
			this.m_btnPrint.Click += new System.EventHandler(this.ButtonPrint_OnClick);
			// 
			// m_btnPageSetup
			// 
			this.m_btnPageSetup.Location = new System.Drawing.Point(16, 24);
			this.m_btnPageSetup.Name = "m_btnPageSetup";
			this.m_btnPageSetup.Size = new System.Drawing.Size(96, 23);
			this.m_btnPageSetup.TabIndex = 0;
			this.m_btnPageSetup.Text = "Page Setup";
			this.m_btnPageSetup.Click += new System.EventHandler(this.ButtonPageSetup_OnClick);
			// 
			// m_btnExit
			// 
			this.m_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.m_btnExit.Location = new System.Drawing.Point(544, 24);
			this.m_btnExit.Name = "m_btnExit";
			this.m_btnExit.Size = new System.Drawing.Size(96, 23);
			this.m_btnExit.TabIndex = 3;
			this.m_btnExit.Text = "Exit";
			this.m_btnExit.Click += new System.EventHandler(this.ButtonExit_OnClick);
			// 
			// m_cbFitToPage
			// 
			this.m_cbFitToPage.Checked = true;
			this.m_cbFitToPage.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_cbFitToPage.Location = new System.Drawing.Point(360, 24);
			this.m_cbFitToPage.Name = "m_cbFitToPage";
			this.m_cbFitToPage.TabIndex = 5;
			this.m_cbFitToPage.Text = "Fit to Page";
			// 
			// MainForm
			// 
			this.AcceptButton = this.m_btnExit;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 390);
			this.Controls.Add(this.m_cbFitToPage);
			this.Controls.Add(this.m_btnPrintPreview);
			this.Controls.Add(this.m_list);
			this.Controls.Add(this.m_btnPrint);
			this.Controls.Add(this.m_btnPageSetup);
			this.Controls.Add(this.m_btnExit);
			this.Name = "MainForm";
			this.Text = "Test Printable List View";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad (e);
			ControlFlatStyle.SetFlatStyleSystem(this);
			FillList();
		}

		private void FillList()
		{
			// Read data from xml file
			DataSet ds = new DataSet();
			try
			{
				ds.ReadXml("Orders.xml", XmlReadMode.ReadSchema);
				FillList(this.m_list, ds.Tables["ORDERS"]);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private void FillList(ListView list, DataTable table)
		{
			list.SuspendLayout();

			// Clear list
			list.Items.Clear();
			list.Columns.Clear();

			// Columns
			foreach (DataColumn col in table.Columns)
			{
				ColumnHeader ch = new ColumnHeader();
				ch.Text = col.Caption;
				if (IsNumeric(col.DataType))
					ch.TextAlign = HorizontalAlignment.Right;
				ch.Width = 100;
				list.Columns.Add(ch);
			}

			// Rows
			foreach (DataRow row in table.Rows)
			{
				ListViewItem item = new ListViewItem();
				item.Text = row[0].ToString();

				for (int i=1; i<table.Columns.Count; i++)
				{
					item.SubItems.Add(row[i].ToString());
				}
				list.Items.Add(item);
			}

			list.ResumeLayout();
		}

		private bool IsNumeric(Type dataType)
		{
			switch(Type.GetTypeCode(dataType)) 
			{ 
				case TypeCode.Byte:
				case TypeCode.SByte:
				case TypeCode.Decimal: 
				case TypeCode.Double: 
				case TypeCode.Int16: 
				case TypeCode.Int32: 
				case TypeCode.Int64: 
				case TypeCode.Single: 
				case TypeCode.UInt16: 
				case TypeCode.UInt32: 
				case TypeCode.UInt64: 
					return true; 
				default: 
					return false; 
			} 
		}

		private void ButtonPageSetup_OnClick(object sender, System.EventArgs e)
		{
			m_list.PageSetup();
		}

		private void ButtonPrintPreview_OnClick(object sender, System.EventArgs e)
		{
			m_list.Title = "Test Printable List View";
			m_list.FitToPage = m_cbFitToPage.Checked;
			m_list.PrintPreview();
		}

		private void ButtonPrint_OnClick(object sender, System.EventArgs e)
		{
			m_list.Title = "Test Printable List View";
			m_list.FitToPage = m_cbFitToPage.Checked;
			m_list.Print();
		}

		private void ButtonExit_OnClick(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}
