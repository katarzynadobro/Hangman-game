using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_game
{
    public partial class frmHangman : Form
    {
        private Bitmap[] hangImages = {Hangman_game.Properties.Resources.1, Hangman_game.Properties.Resources.2, Hangman_game.Properties.Resources.3, Hangman_game.Properties.Resources.4, Hangman_game.Properties.Resources.5, Hangman_game.Properties.Resources.6, Hangman_game.Properties.Resources.7 };
        private int wrongGuesses = 0;
        public frmHangman()
        {
            InitializeComponent();
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            wrongGuesses++;
            pictureBox2.Image = handImages[wrongGuesses]
        }
    }
}
