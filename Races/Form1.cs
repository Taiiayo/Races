using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Races
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] players = new Guy[3];
        Random MyRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            dogs[0] = new Greyhound { MyPictureBox = pictureBox1, StartingPosition = pictureBox1.Left, RacetrackLength = racetrack.Width - pictureBox1.Width, Randomizer = MyRandomizer };
            dogs[1] = new Greyhound { MyPictureBox = pictureBox2, StartingPosition = pictureBox2.Left, RacetrackLength = racetrack.Width - pictureBox2.Width, Randomizer = MyRandomizer };
            dogs[2] = new Greyhound { MyPictureBox = pictureBox3, StartingPosition = pictureBox3.Left, RacetrackLength = racetrack.Width - pictureBox3.Width, Randomizer = MyRandomizer };
            dogs[3] = new Greyhound { MyPictureBox = pictureBox4, StartingPosition = pictureBox4.Left, RacetrackLength = racetrack.Width - pictureBox4.Width, Randomizer = MyRandomizer };

            players[0] = new Guy { Name = "Joe", Cash = 50, MyBet = null, MyLabel = joeBetLabel, MyRadioButton = JoeRadioButton };
            players[1] = new Guy { Name = "Bob", Cash = 75, MyBet = null, MyLabel = bobBetLabel, MyRadioButton = BobRadioButton };
            players[2] = new Guy { Name = "Al", Cash = 45, MyBet = null, MyLabel = alBetLabel, MyRadioButton = AlRadioButton };

            foreach (Guy player in players)
            {
                player.UpdateLabels();
            }
        }



        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = players[0].Name;
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = players[1].Name;
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = players[2].Name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i].Run())
                {
                    // we have a winner!
                    // call timer1.Stop() to stop the dogs
                    //show a message saying who won
                    //each Guy collects his winnings

                    timer1.Stop();

                    int Winner = i + 1;
                    MessageBox.Show("Dog# " + Winner + " won!");
                 
                    foreach (Guy player in players)
                    {
                        player.Collect(Winner);
                    }

                    foreach (Greyhound dog in dogs)
                    {
                        dog.TakeStartingPosition();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Greyhound dog in dogs)
            {
                timer1.Start();
                dog.TakeStartingPosition();
            }
           
        }

        private void whoBets_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.players.Length; i++)
            {
                if (this.players[i].Name == name.Text)
                {
                    players[i].PlaceBet((int)betAmount.Value, (int)dogNumber.Value);
                    players[i].UpdateLabels();
                }
            }
        }
    }
}
