using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            Button b;
            int x = 0;
            flowLayoutPanel1.Dispose();
            for (int i = 1; i <= Convert.ToInt32(txtAdet.Text); i++)
            {
                b = new Button();
                b.Text = i.ToString();
                b.Size = new Size(100, 50);
               // b.Location = new Point( x * 100 + 10,50);
               // x++;
                flowLayoutPanel1.Controls.Add(b);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
