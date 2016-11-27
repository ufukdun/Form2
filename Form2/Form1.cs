using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int red, green, blue;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                System.Drawing.Color renk = RenkOlustur();
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
                btn.BackColor = renk;
                btn.Left = 100 + (btn.Width * i);
                btn.Tag = renk;
                btn.Click += btn_Click;
                this.Controls.Add(btn);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button secilenBtn = (Button)sender;
            this.BackColor = (System.Drawing.Color)secilenBtn.BackColor;
        }
        private System.Drawing.Color RenkOlustur()
        {
            red = random.Next(0, 256);
            green = random.Next(0, 256);
            blue = random.Next(0, 256);

            System.Drawing.Color randomRenk = System.Drawing.Color.FromArgb(red, green, blue);
            return randomRenk;
        }
    }
}
