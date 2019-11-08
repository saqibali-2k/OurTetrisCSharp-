using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        Statistics stats = new Statistics();
        public Form1()
        {
            InitializeComponent();
            Tetrominoes.Add(1, IBlock);
            Tetrominoes.Add(2, LBlock);
            Tetrominoes.Add(3, JBlock);
            Tetrominoes.Add(4, OBlock);
            Tetrominoes.Add(5, SBlock);
            Tetrominoes.Add(6, TBlock);
            Tetrominoes.Add(7, ZBlock);
            //Setting up the scoreboard and starting the timer
            stats.ReadHighscore();
            lblHighScore.Text = Convert.ToString(stats.iHighScore);
            lblCurrentScore.Text = "0";          
            Timer.Enabled = true;
           

        }
        //Makes it easier to make a random shaped block when a random number generator is used
        static Dictionary<int, int[,]> Tetrominoes = new Dictionary<int, int[,]>();
        static Random Rnd = new Random();
        Game Tetris = new Game();
        Block FreeBlock = new Block(Rnd);
        Block NextBlock = new Block(Rnd);

        //Tetrominoes
        int[,] IBlock = new[,] { { 0, 0, 0, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 0, 1, 0, 0 }
                                                 };


        int[,] JBlock = new[,] { { 0, 0, 0, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 1, 1, 0, 0 },
                                 { 0, 0, 0, 0, 0 }
                                                 };

        int[,] LBlock = new[,] { { 0, 0, 0, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 0, 1, 1, 0 },
                                 { 0, 0, 0, 0, 0 }
                                                 };

        int[,] OBlock = new[,] { { 0, 0, 0, 0, 0 },
                                 { 0, 0, 1, 1, 0 },
                                 { 0, 0, 1, 1, 0 },
                                 { 0, 0, 0, 0, 0 },
                                 { 0, 0, 0, 0, 0 }
                                                 };

        int[,] SBlock = new[,] { { 0, 0, 0, 0, 0 },
                                 { 0, 0, 0, 0, 0 },
                                 { 0, 0, 1, 1, 0 },
                                 { 0, 1, 1, 0, 0 },
                                 { 0, 0, 0, 0, 0 }
                                                 };


        int[,] TBlock = new[,] { { 0, 0, 0, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 1, 1, 0, 0 },
                                 { 0, 0, 1, 0, 0 },
                                 { 0, 0, 0, 0, 0 }
                                                 };

        int[,] ZBlock = new[,] { { 0, 0, 0, 0, 0 },
                                 { 0, 0, 0, 0, 0 },
                                 { 0, 1, 1, 0, 0 },
                                 { 0, 0, 1, 1, 0 },
                                 { 0, 0, 0, 0, 0 }
                                                 };

        //Draw block and field seperately until they become one

        //Block Class to manage blocks
        public class Block
        {
            Random rnd;
            protected int iType;
            protected int iRotation;
            public Color col;
            //Top Left of Kernel
            public int iLocationX, iLocationY;

            public Block(Random r)
            {
                //A new block is not placed

                rnd = r;
                //Spawn Location
                iLocationX = 5;
                iLocationY = -4;

                iRotation = 0;

                //Color Block
                iType = rnd.Next(1, 8);

                if (iType == 1)
                {
                    col = Color.Red;
                }
                else if (iType == 2)
                {
                    col = Color.Green;
                }
                else if (iType == 3)
                {
                    col = Color.Blue;
                }
                else if (iType == 4)
                {
                    col = Color.LightBlue;
                }
                else if (iType == 5)
                {
                    col = Color.Orange;
                }
                else if (iType == 6)
                {
                    col = Color.Yellow;
                }
                else if (iType == 7)
                {
                    col = Color.Violet;
                }
            }

        

            public Block()
            {
                //A new block is not placed

                rnd = new Random();
                //Spawn Location
                iLocationX = 5;
                iLocationY = -4;

                iRotation = 0;

                //Random Block

                iType = rnd.Next(1, 8);

                //Block Color
                int iColour = rnd.Next(1, 4);

                if (iType == 1)
                {
                    col = Color.Red;
                }
                else if (iType == 2)
                {
                    col = Color.Green;
                }
                else if (iType == 3)
                {
                    col = Color.Blue;
                }
                else if (iType == 4)
                {
                    col = Color.LightBlue;
                }
                else if (iType == 5)
                {
                    col = Color.Orange;
                }
                else if (iType == 6)
                {
                    col = Color.Yellow;
                }
                else if (iType == 7)
                {
                    col = Color.Violet;
                }
            

        }

            //Setter and getter for Isplaced;

            public int GetType()
            {
                return iType;
            }

            public int MoveBlock(int ChangeX, int ChangeY, bool[,] Grid)
            {

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (TetronimoOrientation(i, j) == 1)
                        {
                            if (iLocationY + j + ChangeY > 19 || iLocationX + i + ChangeX > 9 || iLocationX + i + ChangeX < 0)
                            {
                                return 0;
                            }

                            //Move is not valid if Block is obstructed by the grid
                            if (iLocationY + j + ChangeY >= 0)
                            {
                                if (Grid[iLocationX + i + ChangeX, iLocationY + j + ChangeY] == true)
                                {
                                    return 0;
                                }
                            }

                        }

                    }

                }

                iLocationX += ChangeX;
                iLocationY += ChangeY;

                return 1;
            }

            public void DrawBlock(Graphics g)
            {
                SolidBrush myBrush = new SolidBrush(col);
                Pen myPen = new Pen(Color.Black, 2);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (TetronimoOrientation(i, j) == 1)
                        {
                            g.FillRectangle(myBrush, iLocationX * 30 + i * 30, iLocationY * 30 + j * 30, 30, 30);
                            g.DrawRectangle(myPen, iLocationX * 30 + i * 30, iLocationY * 30 + j * 30, 30, 30);

                        }

                    }
                }
            }

            //Specific for drawing the next block
            public void DrawBlock(Graphics g, int X, int Y)
            {
                SolidBrush myBrush = new SolidBrush(col);
                Pen myPen = new Pen(Color.Black, 2);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (TetronimoOrientation(i, j) == 1)
                        {
                            g.FillRectangle(myBrush, X * 15 + i * 15, Y * 15 + j * 15, 15, 15);
                            g.DrawRectangle(myPen, X * 15 + i * 15, Y * 15 + j * 15, 15, 15);

                        }

                    }
                }
            }
            //x,y is the point where the new block is to be placed, while rotations are given by the respective formulas
            public int TetronimoOrientation(int x, int y)
            {
                if (iRotation % 4 == 0)
                {
                    return Tetrominoes[iType][x, y];
                }
                else if (iRotation % 4 == 1)
                {
                    return Tetrominoes[iType][4 - y, x];
                }
                else if (iRotation % 4 == 2)
                {
                    return Tetrominoes[iType][4 - x, 4 - y];
                }
                else
                {
                    return Tetrominoes[iType][y, 4 - x];
                }
            }
            //Specifically to see if a rotation is possible without rotating The rotation used here is not the current rotated state of block
            public int TetronimoOrientation(int x, int y, int iRotation)
            {
                if (iRotation % 4 == 0)
                {
                    return Tetrominoes[iType][x, y];
                }
                else if (iRotation % 4 == 1)
                {
                    return Tetrominoes[iType][4 - y, x];
                }
                else if (iRotation % 4 == 2)
                {
                    return Tetrominoes[iType][4 - x, 4 - y];
                }
                else
                {
                    return Tetrominoes[iType][y, 4 - x];
                }
            }

            public void Rotate(bool[,] Grid)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        //Makes sure Rotation will not cause overflow
                        if (iLocationX + i < 10 && iLocationX + i >= 0 && iLocationY + j < 20 && iLocationY + j >= 0)
                        {
                            //Rotation does not overlap with the already placed blocks
                            if (TetronimoOrientation(i, j, iRotation + 1) == 1 && Grid[iLocationX + i, iLocationY + j] == true)
                                return;
                        }
                        //Block isnt on grid and a piece that must be displayed is off (NOTE: && iLocationY + j >= 0 is excluded to allow rotations b4 the shape enters grid)
                        else if (!(iLocationX + i < 10 && iLocationX + i >= 0 && iLocationY + j < 20) && TetronimoOrientation(i, j, iRotation + 1) == 1)
                            return;
                    }
                }

                iRotation += 1;

            }

            public Point Apparition(bool[,] Grid)
            {
                //Apparition, or ghost block shows where the block will land
                Point ApparitionLocation = new Point(iLocationX, iLocationY);

                while (true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            //Looks at only the blocks that are coloured in the Tetronimo kernel
                            if (TetronimoOrientation(i, j) == 1)
                            {
                                //Block tries to move off the grid
                                if (ApparitionLocation.Y + j + 1 > 19)
                                {
                                    //If block can not move down futher, then apparition location has been found
                                    return ApparitionLocation;
                                }

                                //Move is not valid if Block is obstructed by the grid
                                if (ApparitionLocation.Y + j + 1 >= 0)
                                {
                                    if (Grid[ApparitionLocation.X + i, ApparitionLocation.Y + j + 1] == true)
                                    {
                                        return ApparitionLocation;
                                    }
                                }

                            }

                        }

                    }
                    //If move is valid, ghost block is moved down once
                    ApparitionLocation.Y += 1;
                }
            }

            //Method for drawing the ghost block
            public void DrawApparition(Graphics g, Point ApparitionLocation)
            {
                Pen myPen = new Pen(col, 1);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (TetronimoOrientation(i, j) == 1)
                        {
                            g.DrawRectangle(myPen, ApparitionLocation.X * 30 + i * 30, ApparitionLocation.Y * 30 + j * 30, 30, 30);
                        }

                    }
                }
            }
        }


        public class Game
        {
            public bool[,] Grid;
            public Color[,] CArray;


            public Game()
            {
                Grid = new bool[10, 20];
                CArray = new Color[10, 20];
            }

            public void ResetGame()
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Grid[i, j] = false;
                        CArray[i, j] = Color.White;
                    }
                }
            }

            public void DrawGame(Graphics g)
            {

                Pen myPen = new Pen(Color.Black, 2);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        SolidBrush myBrush = new SolidBrush(CArray[i, j]);

                        g.FillRectangle(myBrush, i * 30, j * 30, 30, 30);

                        if (Grid[i, j] == true)
                        {
                            g.DrawRectangle(myPen, i * 30, j * 30, 30, 30);
                        }


                    }
                }
            }



        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Tetris.ResetGame();

        }

        private void pbGame_Paint(object sender, PaintEventArgs e)
        {
            Tetris.DrawGame(e.Graphics);

            if (Timer.Enabled)
            {

                //Display Apparition Block
                FreeBlock.DrawApparition(e.Graphics, FreeBlock.Apparition(Tetris.Grid));
                //DrawBlock
                FreeBlock.DrawBlock(e.Graphics);
            }
            else if(Timer.Enabled ==false && lblGamePaused.Visible)
            {
                //Will still draw if game is paused
                FreeBlock.DrawApparition(e.Graphics, FreeBlock.Apparition(Tetris.Grid));
                FreeBlock.DrawBlock(e.Graphics);
            }


        }
        public bool AreCompleteRows(int iYLocation)
        {
            for (int i = 0; i < 10; i++)
            {
                if (Tetris.Grid[i, iYLocation] == true)
                {

                }
                else
                {
                    return false;
                }
            }
            stats.iScore += 100;
            UpdateScore();
            return true;

        }
        //Method for removing a completedd row
        public async void RemoveRow(int iYLocation)
        {
            //Animation fo line remove that clears more blocks than it needs to
            /*Timer.Enabled = false;
            for (int i = 0; i < 10; i++)
            {
                Tetris.CArray[i, iYLocation] = Color.White;

                Task wait = Task.Delay(50);
                await wait;

                pbGame.Invalidate();

            }
            Timer.Enabled = true;*/

            for (int i = 0; i < 10; i++)
            {
                for (int j = iYLocation; j > 0; j--)
                {
                    Tetris.CArray[i, j] = Tetris.CArray[i, j - 1];
                    Tetris.Grid[i, j] = Tetris.Grid[i, j - 1];
                }
            }

        }

        //Class for storing and readingstatistics
        class Statistics
        {
            public int iScore;
            public int iHighScore;

            public Statistics()
            {
                iScore = 0;
                iHighScore = 0;
            }
            public Statistics(int highscore)
            {
                iHighScore = highscore;
            }       
            public void SaveHighscore()
            {
                //Creating a text writes and opening the file
                TextWriter twSaveScore = new StreamWriter("statistics.txt");

                twSaveScore.Write(iHighScore);

                //Closing text writer
                twSaveScore.Close();
            }
            public void ReadHighscore()
            {               
                TextReader trLoadScore = new StreamReader("statistics.txt");
                iHighScore = Convert.ToInt32(trLoadScore.ReadLine());
                trLoadScore.Close();
            }          

        }
        //Updates the score
        public void UpdateScore()
        {
            lblCurrentScore.Text = Convert.ToString(stats.iScore);
            if (stats.iScore > stats.iHighScore)
            {
                stats.iHighScore = stats.iScore;
                lblHighScore.Text = Convert.ToString(stats.iHighScore);
            }
            IntervalChange(stats.iScore);

        }
        //Resets the score
        public void ResetScore()
        {
            stats.iScore = 0;
            lblCurrentScore.Text = "0";
        }
        //Changes the speed of the game
        public void IntervalChange(int score)
        {
            if (score <= 1500)
                Timer.Interval = 750;
            else if (score <= 4000 && score > 1500)
                Timer.Interval = 500;
            else
                Timer.Interval = 250;
        }
            


        private void PlaceBlock()
        {
            //If block movement was not successful and the block was on the grid
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //The data point in the kernel is not blank
                    if (FreeBlock.TetronimoOrientation(i, j) == 1)
                    {
                        //The placed block is now transferred onto the grid
                        Tetris.CArray[FreeBlock.iLocationX + i, FreeBlock.iLocationY + j] = FreeBlock.col;
                        Tetris.Grid[FreeBlock.iLocationX + i, FreeBlock.iLocationY + j] = true;
                    }

                }
            }
            stats.iScore += 20;
            UpdateScore();
            
        }

        private bool BlockonGrid()
        {
            //Checks if the block is on the grid checking all blocks of the kernel
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (FreeBlock.TetronimoOrientation(i, j) == 1 && FreeBlock.iLocationY + j < 0)
                    {
                        return false;
                    }

                }
            }

            return true;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            //Moves block and makes sure the the movement was successful (if 0 is returned movement is unsuccessful)
            if (FreeBlock.MoveBlock(0, 1, Tetris.Grid) == 0)
            {

                if (BlockonGrid())
                {
                    
                        PlaceBlock();
                    
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (FreeBlock.TetronimoOrientation(i, j) == 1)
                            {
                                if (AreCompleteRows(FreeBlock.iLocationY + j) == true)
                                {
                                    //Rows above are shifted and corrent row is removed
                                    RemoveRow(FreeBlock.iLocationY + j);
                                }
                            }
                        }
                    }

                    //New block is created as game continues
                    FreeBlock = NextBlock;
                    NextBlock = new Block();
                    pbExtras.Invalidate();

                }
                //If block does not move and it is not on grid (GameOver)
                else if (!BlockonGrid())
                {
                    Timer.Enabled = false;
                    lblGameOver.Visible = true;
                    Timer.Interval = 1000;

                }
            }

            pbGame.Invalidate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //KeyPresses only work while the timer is running
            if (Timer.Enabled == true)
            {
                if (keyData == Keys.Left)
                {
                    FreeBlock.MoveBlock(-1, 0, Tetris.Grid);
                }
                else if (keyData == Keys.Right)
                {
                    FreeBlock.MoveBlock(1, 0, Tetris.Grid);
                }
                else if (keyData == Keys.Down)
                {
                    FreeBlock.MoveBlock(0, 1, Tetris.Grid);
                }
                else if (keyData == Keys.Z)
                {
                    //Will not rotate O block
                    if (FreeBlock.GetType() != 4)
                        FreeBlock.Rotate(Tetris.Grid);
                }
                else if (keyData == Keys.Up)
                {
                    Point Drop = FreeBlock.Apparition(Tetris.Grid);
                    FreeBlock.iLocationX = Drop.X;
                    FreeBlock.iLocationY = Drop.Y;
                    if (BlockonGrid())
                    {
                        {
                            PlaceBlock();
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (FreeBlock.TetronimoOrientation(i, j) == 1)
                                    {
                                        if (AreCompleteRows(FreeBlock.iLocationY + j) == true)
                                        {
                                            //Rows above are shifted and corrent row is removed
                                            RemoveRow(FreeBlock.iLocationY + j);
                                        }
                                    }
                                }
                            }
                        }                      
                    }
                    else
                    {
                        Timer.Enabled = false;
                        lblGameOver.Visible = true;
                        Timer.Interval = 1000;

                    }

                    pbExtras.Invalidate();

                    FreeBlock = NextBlock;
                    NextBlock = new Block();
                }

                pbGame.Invalidate();
            }
            //Pauses game
            if (keyData == Keys.Escape)
            {
                if (Timer.Enabled == true)
                {
                    Timer.Enabled = false;
                    lblGamePaused.Visible = true;
                }

                else
                {
                    Timer.Enabled = true;
                    lblGamePaused.Visible = false;
                }

            }

            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void pbExtras_Paint(object sender, PaintEventArgs e)
        {
            NextBlock.DrawBlock(e.Graphics, 0, 0);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Stores status of timer
            bool TimerStatus = Timer.Enabled;

            Timer.Enabled = false;

            DialogResult Restart = MessageBox.Show("Would you like to Restart? This will make you lose progress!", "Notice", MessageBoxButtons.YesNo);

            if(Restart == DialogResult.Yes)
            {
                lblGameOver.Visible = false;
                Tetris.ResetGame();
                Timer.Interval = 1000;
                FreeBlock = new Block();
                NextBlock = new Block();
                //Rest timer status does not need to be restored, so we can return here
                Timer.Enabled = true;
                ResetScore();
                return;

            }
            //Status of timer is restored
            Timer.Enabled = TimerStatus;

        }
        
        //Saves high score upon game close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stats.SaveHighscore();
        }
    }
}
