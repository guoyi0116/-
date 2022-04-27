using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonlord_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int h, w;
            bmp = new Bitmap(pictureBox2.Image);
            w = bmp.Width;
            h = bmp.Height;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int avg = (int)(p.R * 0.3 + p.G * 0.6 + p.B * 0.1);
                    bmp.SetPixel(x, y, Color.FromArgb(p.A, avg, avg, avg));
                }
            }

            pictureBox3.Image = bmp;
        }

        private void btnLord2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Title = "請選擇圖形檔";
            dia.Filter = "jpeg files|*.jpg";
            if (dia.ShowDialog() == DialogResult.OK) ;
            {
               pictureBox2.Load(dia.FileName);
            }
        }

        private void butngray_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int h, w;
            bmp = new Bitmap(pictureBox2.Image);
            w = bmp.Width;
            h = bmp.Height;
            for(int y = 0; y < h; y++)
            {
                for(int x = 0; x <w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(p.A, 255 - p.R, 255 - p.G, 255 - p.B));
                }
            }
         
            pictureBox3.Image = bmp;
        }

        private void btnlightup_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int h, w;
            bmp = new Bitmap(pictureBox2.Image);
            w = bmp.Width;
            h = bmp.Height;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int r = (int)(p.R * 1.2 > 255 ? 255 : p.R * 1.2);
                    int b = (int)(p.B * 1.2 > 255 ? 255 : p.B * 1.2);
                    int g = (int)(p.G * 1.2 > 255 ? 255 : p.G * 1.2);


                    bmp.SetPixel(x, y, Color.FromArgb(p.A, r, b, g));
                }
            }

            pictureBox3.Image = bmp;
        }

        private void marcycar_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int h, w;
            bmp = new Bitmap(pictureBox2.Image);
            w = bmp.Width;
            h = bmp.Height;
            const int size = 20;

            for (int y = 0; y < h; y=size   )
            {
                for (int x = 0; x < w; x=size)
                {
                    Color p = bmp.GetPixel(x, y);
                    for(int i = 0; i < size; i++)
                    {
                        for(int j = 0; j < size; j++)
                        {
                            bmp.SetPixel(x + i, y + j, p);
                        }
                            
                        
                    }


                   
                }
            }

            pictureBox3.Image = bmp;
        }
    }
}
