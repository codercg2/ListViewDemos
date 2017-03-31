using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GroupableListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                exListView1.Items.Add(new ListViewItem(new string[] { "Smith W.", "Male", "Historian" },0));
                exListView1.Items.Add(new ListViewItem(new string[] { "Jones A.", "Male", "Architect" }, 0));
                exListView1.Items.Add(new ListViewItem(new string[] { "Dary J.", "Female", "Entertainer" }, 1));
                exListView1.Items.Add(new ListViewItem(new string[] { "Timor M.", "Female", "Developer" },1));
                exListView1.Items.Add(new ListViewItem(new string[] { "Parker F.", "Male", "Beta-Tester" }, 0));
                exListView1.Items.Add(new ListViewItem(new string[] { "Smith R.", "Male", "Developer" }, 0));
                exListView1.Items.Add(new ListViewItem(new string[] { "Timor M.", "Male", "Architect" }, 0));
                exListView1.Items.Add(new ListViewItem(new string[] { "Dary A.", "Female", "Entertainer" }, 1));
            
        }

        private void exListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}