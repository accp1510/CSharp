using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lek11
{
    public class Section
    {
        public int X;
        public int Y;
        public int radius=50;
        public Section prev;
        public Bitmap bitmap;

        public Section(Section prev)
        {
            this.prev = prev;
            Image im = Image.FromFile("Assets\\round.png");
            bitmap = new Bitmap(im,new Size(radius,radius));
        }

        public virtual void Update() {
            if (prev!=null)
            {
                X = prev.X;
                Y = prev.Y;
            }
        }

        public void Draw(Graphics g) {
            g.DrawImage(bitmap, X, Y);
        }

    }
}
