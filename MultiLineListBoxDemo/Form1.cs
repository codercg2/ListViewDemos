using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MultiLineListBoxDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private NishBox.MultiLineListBox multiLineListBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			string s = "There was this guy from Trivandrum " +
				"who wanted to travel all round the world. " +
				"But this guy from Trivandrum could not manage " +
				"to do that and he's heart broken. All the queen's " +
				"soldiers and all the queen's men " +
				"couldn't put his poor heart together again";

			multiLineListBox1.Items.Add(s);

			s = "Colin Davies, James Johnson, Jack Handy, Shog9, " +
				"Roger Wright, Roger Allen, PJ, Nnamdi, Mike Dunn, " +
				"Christian Graus, Nish, Cathy, Smitha, Lauren, " +
				"Kannan Kalyanaraman, Simon Walton, Isaac Sasson, " +
				"Matt Newman, Paul Watson, Andrew Peace - these fellows " +
				"are often found on Bob's HungOut";

			multiLineListBox1.Items.Add(s);

			s = "Chris Maunder and David Cunningham run the Code Project web site";

			multiLineListBox1.Items.Add(s);

			s = "I thoth I tho a puthy cath. I thoth I tho another puthy cath. " +
				"I deed. I deed tho a puthy cath and I deed tho another puthy cath";

			multiLineListBox1.Items.Add(s);

			s = "I believe I can fly, I believe I can touch the sky. " +
				"I think about it every night and day, spread my wings " +
				"and I fly away. I belive I can fly.";

			for(int i=0; i<3; i++)
				multiLineListBox1.Items.Add(s);

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
			this.multiLineListBox1 = new NishBox.MultiLineListBox();
			this.SuspendLayout();
			// 
			// multiLineListBox1
			// 
			this.multiLineListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.multiLineListBox1.Location = new System.Drawing.Point(16, 24);
			this.multiLineListBox1.Name = "multiLineListBox1";
			this.multiLineListBox1.ScrollAlwaysVisible = true;
			this.multiLineListBox1.Size = new System.Drawing.Size(296, 280);
			this.multiLineListBox1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(338, 318);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.multiLineListBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Editable multi-line listbox - Nish";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
