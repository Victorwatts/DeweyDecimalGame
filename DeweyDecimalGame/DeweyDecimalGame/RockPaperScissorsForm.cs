using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalGame
{
    public partial class RockPaperScissorsForm : Form
    {
        public Random rnd = new Random();
        public string PC_Selected;
        public string User_Selected;

        public RockPaperScissorsForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            ResetGame();
            //Paper.Enabled = false;
            //Scissors.Enabled = false;
            lbl_UserChoice.Text = "Rock";
            User_Selected = "Rock";
            Rock.BackColor = Color.Green;
            RandomPicker();
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            ResetGame();
           //Rock.Enabled = false;
           // Scissors.Enabled = false;
            lbl_UserChoice.Text = "Paper";
            User_Selected = "Paper";
            Paper.BackColor = Color.Green;
            RandomPicker();
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            ResetGame();
            //Paper.Enabled = false;
            //Rock.Enabled = false;
            lbl_UserChoice.Text = "Scissors";
            User_Selected = "Scissors";
            Scissors.BackColor = Color.Green;
            RandomPicker();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            Paper.Enabled = true;
            Rock.Enabled = true;
            Scissors.Enabled = true;
            Paper.BackColor = Color.LightSkyBlue;
            Rock.BackColor = Color.LightSkyBlue;
            Scissors.BackColor = Color.LightSkyBlue;
            PC_Rock.BackColor = Color.FromArgb(255, 119, 121);
            PC_Paper.BackColor = Color.FromArgb(255, 119, 121);
            PC_Scissors.BackColor = Color.FromArgb(255, 119, 121);
            lbl_UserChoice.Text = "";
            lbl_Result.Text = "";
            lbl_PC_Choice.Text = "";
        }

        private void RandomPicker()
        {
            int computerSelection = rnd.Next(1, 4);
            if (computerSelection == 1)
            {
                lbl_PC_Choice.Text = "Rock";
                PC_Selected = "Rock";
                PC_Rock.BackColor = Color.Green;

            }
            else 
            if (computerSelection == 2)
            {
                lbl_PC_Choice.Text = "Paper";
                PC_Selected = "Paper";
                PC_Paper.BackColor = Color.Green;

            }
            else 
            if (computerSelection == 3)
            {
                lbl_PC_Choice.Text = "Scissors";
                PC_Selected = "Scissors";
                PC_Scissors.BackColor = Color.Green;

            }
            CheckWinner();
        }

        private void CheckWinner()
        {
            if (User_Selected.Equals("Rock") && PC_Selected.Equals("Rock") || User_Selected.Equals("Paper") && PC_Selected.Equals("Paper") || User_Selected.Equals("Scissors") && PC_Selected.Equals("Scissors"))
            {
                lbl_Result.Text = "Draw, no winner selected";
            }
            else if (User_Selected.Equals("Rock") && PC_Selected.Equals("Paper"))
            {
                lbl_Result.Text = "Computer Wins, Paper beats rock!";
            }
            else if (User_Selected.Equals("Rock") && PC_Selected.Equals("Scissors"))
            {
                lbl_Result.Text = "User Wins, Rock beats scissors!";
            }
            else if (User_Selected.Equals("Paper") && PC_Selected.Equals("Scissors"))
            {
                lbl_Result.Text = "Computer Wins, Scissors beats paper!";
            }
            else if (User_Selected.Equals("Paper") && PC_Selected.Equals("Rock"))
            {
                lbl_Result.Text = "User Wins, Paper beats rock!";
            }
            else if (User_Selected.Equals("Scissors") && PC_Selected.Equals("Rock"))
            {
                lbl_Result.Text = "Computer Wins, Rock beats scissors!";
            }
            else if (User_Selected.Equals("Scissors") && PC_Selected.Equals("Paper"))
            {
                lbl_Result.Text = "User Wins, Scissors beats paper!";
            }
        }
    }
}
