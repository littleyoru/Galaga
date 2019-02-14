using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Galaga
{
    abstract class Element
    {
        protected static Bitmap image;
        public Graphics graphics;
        public PictureBox frame;

        public void DrawElement(int X, int Y, int width, int height, PictureBox PlaySpace)
        {
            frame = new PictureBox
            {
                BackColor = Color.FromArgb(64, 64, 64),
                Location = new Point(X, Y),
                Size = new Size(width, height)
            };
            PlaySpace.Controls.Add(frame);
            graphics = frame.CreateGraphics();
            graphics.Clear(Color.FromArgb(64, 64, 64));

            graphics.DrawImage(image, X, Y, width, height);
            frame.Image = image;
        }
        
    }
    class Player : Element
    {
        public Player()
        {
            image = new Bitmap(Image.FromFile(@"C:\Users\Elena\source\repos\Galaga\Galaga\Images\ship.png"), 35, 35);
        }
        public async void Shoot(Graphics g, PictureBox PlaySpace, Bitmap bmp, List<Enemy> enemies, Label scoreLabel)
        {
            var bullet = new Bullet();
            bullet.DrawElement(frame.Location.X + 14, frame.Location.Y - 14, 6, 14, PlaySpace);
            PlaySpace.Image = bmp;

            // shoot and set score
            int score = await bullet.MoveBullet(bullet.frame, PlaySpace, bmp, enemies);
            // race condition (if lock is removed)
            lock (scoreLabel)
            {
                int newScore = int.Parse(scoreLabel.Text) + score;
                scoreLabel.Text = newScore.ToString();
            }

            PlaySpace.Image = bmp;
        }
        public void Move(string direction, int playWidth)
        {
            var x = frame.Location.X;
            var y = frame.Location.Y;
            if (direction == "left")
            {
                x -= 2;
            }
            else if (direction == "right")
            {
                x += 2;
            }
            if (x > 5 && x < playWidth - 40)
            {
                frame.Location = new Point(x, y);
            }
        }
    }
    class Enemy: Element
    {
        public static int Score = 30;
        public Enemy()
        {
            image = new Bitmap(Image.FromFile(@"C:\Users\Elena\source\repos\Galaga\Galaga\Images\enemy.png"), 35, 30);
        }
    }
    class Bullet: Element
    {
        public Bullet()
        {
            image = new Bitmap(Image.FromFile(@"C:\Users\Elena\source\repos\Galaga\Galaga\Images\bullet.png"), 6, 14);
        }
        
        public async Task<int> MoveBullet(PictureBox bulletFrame, PictureBox PlaySpace, Bitmap bmp, List<Enemy> enemies)
        {

            var x = bulletFrame.Location.X;
            var y = bulletFrame.Location.Y;

            while (y > 0)
            {
                y -= 2;
                bulletFrame.Location = new Point(x, y);
                PlaySpace.Image = bmp;
                // collision detection
                foreach (var enemy in enemies)
                {
                    if (y <= enemy.frame.Location.Y + 30 && x > enemy.frame.Location.X - 6 && x < enemy.frame.Location.X + 35)
                    {
                        enemy.frame.Dispose();
                        enemies.Remove(enemy);
                        bulletFrame.Dispose();
                        return Enemy.Score;
                    }
                }
                await Task.Delay(5);
            }
            bulletFrame.Dispose();
            return 0;

        }
    }
}
