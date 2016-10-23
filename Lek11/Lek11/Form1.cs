using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Lek11
{
    public partial class Form1 : Form
    {
        public Game game;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            game.GameControl(e.KeyCode);
            if (e.KeyCode == Keys.Space)
            {
                game.Start();
            }

            if (e.KeyCode == Keys.Escape)
            {
                game.Stop();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(panel1.Width, panel1.Height);
            game.DrawGame += new Action(game_DrawGame);
        }

        void game_DrawGame()
        {
            panel1.Invoke(new MethodInvoker(
                delegate { panel1.Refresh(); }
                ));
        }


    }
}
