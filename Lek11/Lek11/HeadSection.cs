using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lek11
{
    public class HeadSection : Section
    {
        public Direction dir = Direction.Up;
        public int step = 50;

        public HeadSection()
            : base(null)
        {
            Image im = Image.FromFile("Assets\\two.png");
            bitmap = new Bitmap(im, new Size(radius, radius));
        }

        public override void Update()
        {
            switch (dir)
            {
                case Direction.Up:
                    Y -= step;
                    break;
                case Direction.Left:
                    X -= step;
                    break;
                case Direction.Right:
                    X += step;
                    break;
                case Direction.Down:
                    Y += step;
                    break;
                default:
                    break;
            }
        }
    }
    public enum Direction
    {
        Up, Left, Right, Down
    }
}
