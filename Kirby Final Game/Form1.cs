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
        Rectangle kirby = new Rectangle(21, 225, 20, 20);
        SolidBrush pinkBrush = new SolidBrush(Color.Pink);
        int kirbySpeed = 10;

        Rectangle boss = new Rectangle(713, 215, 40, 40);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        int bossSpeed = 10;

        Rectangle powerup = new Rectangle(300, 200, 10, 10);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        Rectangle bossBoundry = new Rectangle(22, 182, 198, 262);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        List<Rectangle> obstacles = new List<Rectangle>();
        List<int> obstacleSpeed = new List<int>();
        int obstacleSize = 6;

        Rectangle kirbysHealth = new Rectangle(84, 401, 40, 80);

        bool leftDown = false;
        bool rightDown = false;
        bool upDown = false;
        bool downDown = false;

        int points = 0;
        int kirbyHealth = 0;

        Random randGen = new Random();
        int randValue;

        string gameState = "waiting";
        public Form1()
        {
            InitializeComponent();
        }

        public void GameInitialize()
        {
            titleLabel.Text = "";
            subtitleLabel.Text = "";
            outputLabel.Text = "";
            healthLabel.Text = $"{kirbyHealth}";
            pointLabel.Text = "";

            points = 0;
            kirbyHealth = 100;

            gametimer.Enabled = true;
            gameState = "running";

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
            }
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
                case Keys.Space:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        GameInitialize();
                    }
                    break;
                case Keys.Escape:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // title screen
            if (gameState == "waiting")
            {
                titleLabel.Text = "KIRBY";
                subtitleLabel.Text = "Press Space Bar to Start or Escape to Exit Game";
                
                pointLabel.Visible = false;
                warningLabel.Visible = false;
                healthLabel.Visible = false;
            }

            else if (gameState == "running")
            {
             // draw kirby and the boss
            e.Graphics.FillRectangle(pinkBrush, kirby);
            e.Graphics.FillRectangle(blueBrush, boss);
            e.Graphics.FillRectangle(yellowBrush, powerup);
                e.Graphics.FillRectangle(yellowBrush, kirbysHealth);

                for (int i = 0; i < obstacles.Count; i++)
                {
                    // draw asteroids
                    e.Graphics.FillRectangle(whiteBrush, obstacles[i]);
                }
            }
            
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            //move kirby  
            if (upDown == true && kirby.Y > 0)
            {
                kirby.Y -= kirbySpeed;
            }

            if (downDown == true && kirby.Y < this.Height - kirby.Height)
            {
                kirby.Y += kirbySpeed;
            }

            if (leftDown == true && kirby.X > 0)
            {
                kirby.X -= kirbySpeed;
            }
            if (rightDown == true && kirby.X < this.Width - kirby.Width)
            {
                kirby.X += kirbySpeed;
            }

            if (kirby.IntersectsWith(bossBoundry) && randValue < 20)
            {
                // move obstacles
                for (int i = 0; i < obstacles.Count; i++)
                {
                    int x = obstacles[i].X + obstacleSpeed[i];
                    obstacles[i] = new Rectangle(x, obstacles[i].Y, 20, obstacleSize);
                }
                // obstacles
                int y = randGen.Next(15, this.Height - 40);
                    {
                        obstacles.Add(new Rectangle(this.Width, y, obstacleSize, obstacleSize));
                        obstacleSpeed.Add(-6);
                    }
                for (int i = 0; i < obstacles.Count; i++)
                {
                    if (obstacles[i].Y > this.Height - obstacleSize)
                    {
                        obstacles.RemoveAt(i);
                        obstacleSpeed.RemoveAt(i);
                    }
                }
            }  
            //speed power-up
            if (kirby.IntersectsWith(powerup))
            {
                int speedPointX = randGen.Next(20, 150);
                int speedPointY = randGen.Next(50, 200);
                powerup.Location = new Point(speedPointX, speedPointY);
                if (kirbySpeed < 7)
                {
                    kirbySpeed++;
                }
            }

            Refresh();
        }
    }
}
