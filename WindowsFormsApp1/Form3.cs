using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] kelimeler;
        string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        private void Form3_Load(object sender, EventArgs e)
        {
            Button btn;
            for (int i = 0; i < harfler.Length; i++)
            {
                btn = new Button();
                btn.Text = harfler[i].ToString();
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
            DosyadanOku();
            YeniOyun();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
           Button tiklanan =sender as Button;
            tiklanan.Enabled = false;
        }

        void DosyadanOku()
        {
            FileStream fs = new FileStream(@"dosyalar\kelime.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string satir= sr.ReadLine();
            sr.Close();
            fs.Close();
            kelimeler = satir.Split(',');

        }

        Random r = new Random();
        string secilen;
        void YeniOyun()
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                flowLayoutPanel1.Controls[i].Enabled = true;
            }

            flowLayoutPanel2.Controls.Clear();
            int indis = r.Next(0, kelimeler.Length);
            secilen = kelimeler[indis];
            Label lbl;
            for (int i = 0; i < secilen.Length; i++)
            {
                lbl = new Label();
                lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lbl.Size = new System.Drawing.Size(50, 50);
                lbl.AutoSize = false;
             
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                flowLayoutPanel2.Controls.Add(lbl);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YeniOyun();
        }
    }
}
