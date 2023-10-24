using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp134
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.IO.FileStream f = new System.IO.FileStream("G:\\User\\test.text", System.IO.FileMode.Create);
            byte[] b = System.Text.Encoding.Unicode.GetBytes(textBox1.Text);
            foreach(byte temp in b)
            { 
                if(byte temp in b)
                 { 
                    if(temp !=32&&temp!=0)
                        f.
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
