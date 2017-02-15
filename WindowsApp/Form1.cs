using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text);
            textBox3.Text = m.ToString();
        }

     
    }
}
