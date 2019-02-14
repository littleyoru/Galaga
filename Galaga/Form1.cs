using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    public partial class Galaga : Form
    {
        private PlayGalaga game;
        public Graphics g;
        public StartObj startObj = new StartObj();
        private static string filePath = @"C:\Users\Elena\source\repos\Galaga\Galaga\highScore.txt";

        public Galaga()
        {
            InitializeComponent();
            KeyDown += Keyboard.OnKeyDown;
            KeyUp += Keyboard.OnKeyUp;

            PlaySpace.Controls.Add(PlayerScore);
            PlaySpace.Controls.Add(Score);
            PlaySpace.Controls.Add(HighScoreLabel);
            PlaySpace.Controls.Add(HighScore);
            
        }

        private async void Galaga_Shown(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            var bmp = new Bitmap(PlaySpace.Width, PlaySpace.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.FromArgb(64, 64, 64));
            PlaySpace.Image = bmp;

            // build game
            startObj.start = false;
            game = new PlayGalaga(startObj);
            await game.ShowStartScreen(g, PlaySpace, bmp);
            PlaySpace.Image = bmp;

            // generate level 1
            game.GenerateLevel(1, PlaySpace, bmp, g);
            moveTimer.Start();

            Timer timer = new Timer();
            timer.Tick += delegate { game.currentPlayer.Shoot(g, PlaySpace, bmp, game.enemies, Score); };
            timer.Interval = 1000;
            timer.Start();

        }

        public async void Galaga_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    int highScore = Utility.ReadFromFile(filePath);
                    int currentScore = int.Parse(Score.Text);
                    if (currentScore > highScore)
                        Utility.WriteToFile(filePath, currentScore.ToString());
                    Application.Exit();
                    break;
                case Keys.Space:
                    startObj.start = true;
                    break;
                default:
                    break;
            }

            await Task.Delay(500);
        }

        private void Galaga_Load(object sender, EventArgs e)
        {
            HighScore.Text = Utility.ReadFromFile(filePath).ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            double x = game.currentPlayer.frame.Location.X;
            int y = game.currentPlayer.frame.Location.Y;
            double velocity = 1000 * 0.002;
            if (Keyboard.IsKeyDown(Keys.Left))
            {
                x -= velocity;
            }
            else if (Keyboard.IsKeyDown(Keys.Right))
            {
                x += velocity;
            }

            var newLocation = new Point((int)x, y);
            if (x > 5 && x < PlaySpace.Width - 40)
            {
                game.currentPlayer.frame.Location = newLocation;
            }
        }
    }
}
