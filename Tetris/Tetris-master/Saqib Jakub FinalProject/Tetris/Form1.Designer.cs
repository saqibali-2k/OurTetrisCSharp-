namespace Tetris
{
    partial class Form1
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
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pbExtras = new System.Windows.Forms.PictureBox();
            this.lblNextBlock = new System.Windows.Forms.Label();
            this.lblGamePaused = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblHighScoreTitle = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGame
            // 
            this.pbGame.BackColor = System.Drawing.Color.White;
            this.pbGame.Location = new System.Drawing.Point(12, 12);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(300, 600);
            this.pbGame.TabIndex = 0;
            this.pbGame.TabStop = false;
            this.pbGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGame_Paint);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pbExtras
            // 
            this.pbExtras.BackColor = System.Drawing.Color.White;
            this.pbExtras.Location = new System.Drawing.Point(360, 347);
            this.pbExtras.Name = "pbExtras";
            this.pbExtras.Size = new System.Drawing.Size(94, 120);
            this.pbExtras.TabIndex = 2;
            this.pbExtras.TabStop = false;
            this.pbExtras.Paint += new System.Windows.Forms.PaintEventHandler(this.pbExtras_Paint);
            // 
            // lblNextBlock
            // 
            this.lblNextBlock.AutoSize = true;
            this.lblNextBlock.BackColor = System.Drawing.Color.Transparent;
            this.lblNextBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextBlock.ForeColor = System.Drawing.Color.White;
            this.lblNextBlock.Location = new System.Drawing.Point(365, 323);
            this.lblNextBlock.Name = "lblNextBlock";
            this.lblNextBlock.Size = new System.Drawing.Size(84, 13);
            this.lblNextBlock.TabIndex = 3;
            this.lblNextBlock.Text = "NEXT BLOCK";
            // 
            // lblGamePaused
            // 
            this.lblGamePaused.AutoSize = true;
            this.lblGamePaused.BackColor = System.Drawing.Color.Transparent;
            this.lblGamePaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePaused.ForeColor = System.Drawing.Color.White;
            this.lblGamePaused.Location = new System.Drawing.Point(335, 211);
            this.lblGamePaused.Name = "lblGamePaused";
            this.lblGamePaused.Size = new System.Drawing.Size(158, 24);
            this.lblGamePaused.TabIndex = 4;
            this.lblGamePaused.Text = "GAME PAUSED";
            this.lblGamePaused.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(368, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(79, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(348, 253);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(134, 24);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // lblHighScoreTitle
            // 
            this.lblHighScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreTitle.ForeColor = System.Drawing.Color.White;
            this.lblHighScoreTitle.Location = new System.Drawing.Point(340, 68);
            this.lblHighScoreTitle.Name = "lblHighScoreTitle";
            this.lblHighScoreTitle.Size = new System.Drawing.Size(148, 24);
            this.lblHighScoreTitle.TabIndex = 7;
            this.lblHighScoreTitle.Text = "HIGH SCORE";
            this.lblHighScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.White;
            this.lblHighScore.Location = new System.Drawing.Point(348, 96);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(134, 24);
            this.lblHighScore.TabIndex = 8;
            this.lblHighScore.Text = "0";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.ForeColor = System.Drawing.Color.White;
            this.lblCurrentScore.Location = new System.Drawing.Point(348, 166);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(134, 24);
            this.lblCurrentScore.TabIndex = 10;
            this.lblCurrentScore.Text = "0";
            this.lblCurrentScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.ForeColor = System.Drawing.Color.White;
            this.lblScoreTitle.Location = new System.Drawing.Point(313, 136);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(191, 24);
            this.lblScoreTitle.TabIndex = 9;
            this.lblScoreTitle.Text = "CURRENT SCORE";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.BlueGridBG;
            this.ClientSize = new System.Drawing.Size(505, 620);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHighScoreTitle);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblGamePaused);
            this.Controls.Add(this.lblNextBlock);
            this.Controls.Add(this.pbExtras);
            this.Controls.Add(this.pbGame);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pbExtras;
        private System.Windows.Forms.Label lblNextBlock;
        private System.Windows.Forms.Label lblGamePaused;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblHighScoreTitle;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblScoreTitle;
    }
}

