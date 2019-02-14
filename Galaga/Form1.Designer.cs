namespace Galaga
{
    partial class Galaga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlaySpace = new System.Windows.Forms.PictureBox();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlaySpace)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaySpace
            // 
            this.PlaySpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaySpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlaySpace.Location = new System.Drawing.Point(0, 0);
            this.PlaySpace.Margin = new System.Windows.Forms.Padding(5);
            this.PlaySpace.MaximumSize = new System.Drawing.Size(700, 700);
            this.PlaySpace.MinimumSize = new System.Drawing.Size(700, 700);
            this.PlaySpace.Name = "PlaySpace";
            this.PlaySpace.Size = new System.Drawing.Size(700, 700);
            this.PlaySpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PlaySpace.TabIndex = 0;
            this.PlaySpace.TabStop = false;
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.Color.Red;
            this.PlayerScore.Location = new System.Drawing.Point(51, 19);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(136, 25);
            this.PlayerScore.TabIndex = 1;
            this.PlayerScore.Text = "Player Score";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Score.Location = new System.Drawing.Point(62, 44);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(23, 25);
            this.Score.TabIndex = 2;
            this.Score.Text = "0";
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.HighScoreLabel.Location = new System.Drawing.Point(513, 19);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(119, 25);
            this.HighScoreLabel.TabIndex = 3;
            this.HighScoreLabel.Text = "High Score";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.BackColor = System.Drawing.Color.Transparent;
            this.HighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HighScore.Location = new System.Drawing.Point(529, 44);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(23, 25);
            this.HighScore.TabIndex = 4;
            this.HighScore.Text = "0";
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 10;
            this.moveTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Galaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.PlaySpace);
            this.Name = "Galaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaga";
            this.Load += new System.EventHandler(this.Galaga_Load);
            this.Shown += new System.EventHandler(this.Galaga_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Galaga_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PlaySpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlaySpace;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label HighScoreLabel;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Timer moveTimer;
    }
}

