using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lek11
{
    public class Fruit
    {
        public int X;
        public int Y;
        public int Width;
        public int Heigth;
        public Bitmap bitmap;
        public int numberCount;

        public Fruit(int x, int y)
        {
            Width = 50;
            Heigth = 50;
            this.X = x;
            this.Y = y;
            Random rand = new Random();
            numberCount = rand.Next(16);
            Image im = Image.FromFile("Assets/preview.jpg");
            bitmap = new Bitmap(im);
        }

        public void Draw(Graphics g)
        {
            Rectangle rect = new Rectangle(X, Y, Width, Heigth);
            Rectangle rect1 = new Rectangle(20+330*numberCount%4,20+330*numberCount/4,330,330);
            g.DrawImage(bitmap, rect, rect1, GraphicsUnit.Pixel);
        }
    }
}
