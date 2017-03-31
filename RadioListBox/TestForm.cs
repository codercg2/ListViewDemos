using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RadioListBox_Test
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void UpdateIndex()
        {
            this.label1.Text = string.Format("Index: {0}", radioListBox1.SelectedIndex);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            UpdateIndex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.radioListBox1.Items.Clear();
            this.radioListBox1.Items.AddRange("Uno,Dos,Tres,Cuatro,Cinco,Seis,Siete,Ocho,Nueve,Diez".Split(new char[] { ',' }));
            UpdateIndex();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.radioListBox1.Items.Clear();
            this.radioListBox1.Items.AddRange("One,Two,Three,Four,Five,Six,Seven,Eight,Nine,Ten, Eleven, Twelve".Split(new char[] { ',' }));
            UpdateIndex();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.radioListBox1.Items.Clear();
            this.radioListBox1.Items.AddRange("Ein,Zwei,Drei,Vier,Fünf,Sechs,Sieben,Acht,Neun,Zen".Split(new char[] { ',' }));
            UpdateIndex();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.radioListBox1.Transparent = this.checkBox1.Checked;
        }
        private void radioListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIndex();
        }
    }
}
