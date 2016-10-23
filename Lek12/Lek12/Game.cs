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
        public List<Fruit> fruits;

        public Game(int width, int height)
        {
            this.width = width;
            this.height = height;
            Fruit fruit = new Fruit(100, 100);
            fruits = new List<Fruit>();
            fruits.Add(fruit);

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
            end = false;
            pause = false;
            thread = new Thread(Run);
            snake = new Snake();
            running = true;
            thread.Start();
            timeDelay = 300;
            fruits.Clear();
            score = 0;
        }

        public bool pause = false;
        public void Pause()
        {
            pause = !pause;
            if (true)
            {
                DrawGame();
            }
        }

        public void Stop()
        {
            running = false;
            end = true;
        }

        public void Run()
        {
            double t = DateTime.Now.Ticks;
            while (running)
            {
                if (!pause)
                {
                    Update(DateTime.Now.Ticks - t);
                    t = DateTime.Now.Ticks;
                    Thread.Sleep(timeDelay);
                }

            }
        }

        double timeFrame = 0;
        int randomFruit = 1;
        int score = 0;
        int timeDelay = 300;
        bool end = false;
        public void Update(double t)
        {
            timeFrame += t;
            if (timeFrame / 10000 > randomFruit * 1000)
            {
                timeFrame = 0;
                Random rand = new Random();
                randomFruit = rand.Next(1, 6);
                int x = rand.Next(width);
                x -= x % 50;
                int y = rand.Next(height);
                y -= y % 50;
                Fruit f = new Fruit(x, y);
                fruits.Add(f);
            }
            snake.Update();
            SnakeBoundOut();

            SnakeEat();
            if (score > 0 && score % 5 == 0 && timeDelay > 100)
            {
                timeDelay -= 10;
            }
            if (snake.SectionBound())
            {
                Stop();
            }
            DrawGame();



        }

        public void SnakeEat()
        {
            Fruit f = null;
            foreach (var item in fruits)
            {
                if (snake.head.X == item.X && snake.head.Y == item.Y)
                {
                    snake.AddSection();
                    f = item;
                    score++;
                    Console.Write("\a");
                    break;
                }
            }
            if (f != null)
            {
                fruits.Remove(f);
            }
        }

        public void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            snake.Draw(g);
            foreach (var item in fruits)
            {
                item.Draw(g);
            }
            if (end)
            {
                Font font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                string game_end = "Game  End";
                float w = width / 2 - font.SizeInPoints * game_end.Length / 2;
                float h = height / 2 - font.Size;
                g.DrawString(game_end, font, Brushes.Red, w, h);


            }
            if (pause)
            {
                Font font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                string game_end = "Pause";
                float w = width / 2 - font.SizeInPoints * game_end.Length / 2;
                float h = height / 2 - font.Size;
                g.DrawString(game_end, font, Brushes.Red, w, h);


            }
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
