using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "hello talal";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "my project";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font = new Font("size change", 16, FontStyle.Bold);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
