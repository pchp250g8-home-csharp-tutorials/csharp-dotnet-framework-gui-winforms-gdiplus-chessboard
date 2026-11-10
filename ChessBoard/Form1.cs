using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Aqua;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int width = ClientSize.Width / 8;
            int height = ClientSize.Height / 8;
            Graphics g = e.Graphics;
            Rectangle[] rects = new Rectangle[32];
            g.Clear(Color.Aqua);
            for (int k = 0; k < 32; k++)
            {
                int i = k / 4;
                int j = (k % 4) * 2 + (i % 2);
                int left = i * width;
                int top = j * height;
                rects[k] = new Rectangle(left, top, width, height);
            }
            g.FillRectangles(Brushes.Brown, rects);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
