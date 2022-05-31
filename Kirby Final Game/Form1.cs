using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirby_Final_Game
{
    public partial class Form1 : Form
    {
        Rectangle kirby = new Rectangle(10, 130, 20, 20);
        SolidBrush pinkBrush = new SolidBrush(Color.Pink);
        int kirbySpeed = 10;

        Rectangle boss = new Rectangle(20, 200, 20, 20);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        int bossSpeed = 10;

        bool leftDown = false;
        bool rightDown = false;
        bool upDown = false;
        bool downDown = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Up:
                    upDown = true;
                    break;
                case Keys.Down:
                    downDown = true;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(pinkBrush, kirby);
            e.Graphics.FillRectangle(blueBrush, boss);
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            //move kirby  
            if (upDown == true && kirby.Y > 47)
            {
                kirby.Y -= kirbySpeed;
            }

            if (downDown == true && kirby.Y < (this.Height - 19) - kirby.Height)
            {
                kirby.Y += kirbySpeed;
            }

            if (leftDown == true && kirby.X > 17)
            {
                kirby.X -= kirbySpeed;
            }
            if (rightDown == true && kirby.X < (this.Width - 17) - kirby.Width)
            {
                kirby.X += kirbySpeed;
            }

            //move boss  
            if (upDown == true && boss.Y > 47)
            {
                boss.Y -= bossSpeed;
            }

            if (downDown == true && boss.Y < (this.Height - 19) - boss.Height)
            {
                boss.Y += bossSpeed;
            }

            if (leftDown == true && boss.X > 17)
            {
                boss.X -= bossSpeed;
            }
            if (rightDown == true && boss.X < (this.Width - 17) - boss.Width)
            {
                boss.X += bossSpeed;
            }
        }
    }
}
