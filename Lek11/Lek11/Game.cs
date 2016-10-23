using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace Lek11
{
    public class Game
    {
        public Snake snake = new Snake();
        public bool running = false;
        public Thread thread;
        public event Action DrawGame;
        public int width;
        public int height;

        public Game(int width, int height)
        {
            this.width = width;
            this.height = height;
            
        }

        public void SnakeBoundOut()
        {
            if (snake.head.X < 0)
            {
                snake.head.X = width - width % 50;
            }
            if (snake.head.Y < 0)
            {
                snake.head.Y = height - height % 50;
            }
            if (snake.head.X > width)
            {
                snake.head.X = 0;
            }
            if (snake.head.Y > height)
            {
                snake.head.Y = 0;
            }

        }


        public void Start()
        {
            if (running)
            {
                return;
            }
            thread = new Thread(Run);
            snake = new Snake();
            running = true;
            thread.Start();
        }

        public void Stop()
        {
            running = false;
        }

        public void Run()
        {
            while (running)
            {
                Update();
                Thread.Sleep(300);
            }
        }

        public void Update()
        {
            snake.Update();
            SnakeBoundOut();
            if (snake.SectionBound())
            {
                Stop();
            }
            DrawGame();
        }

        public void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            snake.Draw(g);
        }

        public void GameControl(Keys k)
        {
            if (k == Keys.Up)
            {
                snake.head.dir = Direction.Up;
            }
            if (k == Keys.Down)
            {
                snake.head.dir = Direction.Down;
            }
            if (k == Keys.Left)
            {
                snake.head.dir = Direction.Left;
            }
            if (k == Keys.Right)
            {
                snake.head.dir = Direction.Right;
            }

        }
    }
}
