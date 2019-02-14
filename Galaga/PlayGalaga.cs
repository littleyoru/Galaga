using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    class PlayGalaga
    {
        private int lives = 2;
        public int Lives
        {
            get => lives;
            set => lives = value;
        }
        private StartObj start;
        public Player currentPlayer;
        public List<Player> spareLives;
        public List<Enemy> enemies;
        public PlayGalaga(StartObj startObj)
        {
            start = startObj;

            spareLives = new List<Player>();
            enemies = new List<Enemy>();

        }

        public async Task ShowStartScreen(Graphics g, PictureBox PlaySpace, Image bmp)
        {
            Font drawFont = new Font("Arial", 15);
            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(255, 220, 56));
            g.DrawString("SPACE to start", drawFont, drawBrush, 150, 200);
            g.DrawString("ESC to exit", drawFont, drawBrush, 170, 250);

            while (start.start == false)
            {
                await Task.Delay(1000);
            }

            drawBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            g.FillRectangle(drawBrush, new Rectangle(150, 200, 500, 100));


        }

        public void InitializePlayer(Graphics g, PictureBox PlaySpace, Bitmap bmp)
        {
            currentPlayer = new Player();
            currentPlayer.DrawElement(250, 480, 35, 35, PlaySpace);
        }

        public void DrawSpareLives(Graphics g, PictureBox PlaySpace, Bitmap bmp)
        {
            int posX = 5;
            int posY = 525;
            for (int i = 0; i < lives; i++)
            {
                var life = new Player();
                life.DrawElement(posX, posY, 35, 35, PlaySpace);
                spareLives.Add(life);
                posX += 55;
            }
        }

        public void DrawEnemies(int level, Graphics g, PictureBox PlaySpace, Bitmap bmp)
        {
            int posX = 100;
            int posY = 60;
            for (int i = 0; i < 7; i++)
            {
                var enemy = new Enemy();
                enemy.DrawElement(posX, posY, 35, 30, PlaySpace);
                enemies.Add(enemy);
                posX += 55;
            }
            posX -= 110;
            posY += 55;
            for (int i = 0; i < 5; i++)
            {
                var enemy = new Enemy();
                enemy.DrawElement(posX, posY, 35, 30, PlaySpace);
                enemies.Add(enemy);
                posX -= 55;
            }
            posX += 110;
            posY += 55;
            for (int i = 0; i < 3; i++)
            {
                var enemy = new Enemy();
                enemy.DrawElement(posX, posY, 35, 30, PlaySpace);
                enemies.Add(enemy);
                posX += 55;
            }
        }
    }
}
