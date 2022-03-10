using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        int coins = 10;
        // random number generator

        // int value for score initialized to 10


        public Form1()
        {

            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            Random randGen = new Random();
            int randomNumber1 = randGen.Next(1, 4);
            int randomNumber2 = randGen.Next(1, 4);
            int randomNumber3 = randGen.Next(1, 4);
          

            coins = coins - 1;
            scoreDisplay.Text = $"{coins}"; 
            switch (randomNumber1)
            {

                case 1:
                    cherry1.Visible = false;
                    daimond1.Visible = false;
                    seven1.Visible = true;
                    break;
                case 2:
                    cherry1.Visible = false;
                    daimond1.Visible = true;
                    seven1.Visible = false;
                    break;
                case 3:
                    cherry1.Visible = true;
                    daimond1.Visible = false;
                    seven1.Visible = false;
                    break;

            }

            switch (randomNumber2)
            {

                case 1:
                    cherry2.Visible = false;
                    daimond2.Visible = false;
                    seven2.Visible = true;
                    break;
                case 2:
                    cherry2.Visible = false;
                    daimond2.Visible = true;
                    seven2.Visible = false;
                    break;
                case 3:
                    cherry2.Visible = true;
                    daimond2.Visible = false;
                    seven2.Visible = false;
                    break;
            }
            switch (randomNumber3)
            {

                case 1:
                    cherry3.Visible = false;
                    daimond3.Visible = false;
                    seven3.Visible = true;
                    break;
                    
                case 2:
                    cherry3.Visible = false;
                    daimond3.Visible = true;
                    seven3.Visible = false;
                    break;
                case 3:
                    cherry3.Visible = true;
                    daimond3.Visible = false;
                    seven3.Visible = false;
                    break;
            }


            if(randomNumber3 == 1 && randomNumber1 == 1 && randomNumber2 == 1) {
                outputLabel.Text = $"you win 10$";
            }
            else if(randomNumber3 == 2 && randomNumber1 == 2 && randomNumber2 == 2)
            {
                outputLabel.Text = $"you win 53$";
            }
            else if (randomNumber3 == 3 && randomNumber1 == 3 && randomNumber2 == 3)
            {
                outputLabel.Text = $"you win 1000$";
            }
            else if (coins == 0)
            {
                outputLabel.Text = $"please pay again";
                coins = 10; 

            }
            else
            {
                outputLabel.Text = $"play again";
            }

            // get random values for each reel (store each in separate int variable)


            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources


            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources


            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         


            // if score has reached 0 display "lose" message and set button enabled property to false


            // display updated score

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
