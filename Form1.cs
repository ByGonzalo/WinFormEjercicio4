using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread H1 = new Thread(new ThreadStart(pro1));
            H1.Start();
        }
        public void pro1()
        {
            {

                int i = 0, c = 0;
                while (c <= 20)
                {
                    Thread.Sleep(100);
                    if (i == 0)
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\gonza\Desktop\Nueva carpeta (2)/perro1.png");
                        Thread.Sleep(100);
                    }
                    i = 1;
                    Thread.Sleep(100);
                    if (i == 1)
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\gonza\Desktop\Nueva carpeta (2)/perro2.jpg");
                        Thread.Sleep(100);
                    }
                    i = 2;
                    Thread.Sleep(100);
                    if (i == 2)
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\gonza\Desktop\Nueva carpeta (2)/perro3.jpg");
                        Thread.Sleep(100);
                    }
                    i = 0;
                    c++;
                }

            }
        }
    }
}
