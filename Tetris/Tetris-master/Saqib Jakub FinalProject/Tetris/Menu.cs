using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form1 PlayScreen = new Form1();
            Hide();
            PlayScreen.ShowDialog();
            Close();            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckHighScore_Click(object sender, EventArgs e)
        {
            int iHighScore = 0;
            TextReader trLoadScore = new StreamReader("statistics.txt");
            iHighScore = Convert.ToInt32(trLoadScore.ReadLine());
            trLoadScore.Close();
            MessageBox.Show("The current high score is " + iHighScore);
        }
    }
}
