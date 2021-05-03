using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difficulty_Settings
{
    public partial class DifficultySettings : Form
    {
        // global variables
        string hero;
        string difficultyLevel;

        public DifficultySettings()
        {
            InitializeComponent();
            //string heroname = nameInput.Text;
            
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            hero = nameInput.Text;
            difficultyLevel = "Easy";

            easyButton.BackColor = Color.Green;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = $"Welcome {hero}";
            outputLabel.Text += $"\nA True Brave Hero! Go Forth and Conquer the {difficultyLevel} path";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            hero = nameInput.Text;
            difficultyLevel = "Medium";

            mediumButton.BackColor = Color.Orange;
            easyButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hero = nameInput.Text;
            difficultyLevel = "Hard";

            hardButton.BackColor = Color.Red;
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
        }
    }
}
