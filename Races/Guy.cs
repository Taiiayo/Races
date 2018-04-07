using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Races
{
    public class Guy
    {
        public string Name; // The guy's name
        public Bet MyBet; // An instance of Bet that has his bet
        public int Cash; // How much cash he has
                         // The last two fields are the guy’s GUI controls on the form
        public RadioButton MyRadioButton; // My RadioButton
        public Label MyLabel; // My Label
        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")

            if (MyBet == null)
            {
                MyLabel.Text = String.Format("{0} hasn't placed a bet", this.Name);
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = String.Format("{0} has {1} bucks", this.Name, this.Cash);
        }
        public void ClearBet() // Reset my bet so it’s zero
        {
            MyBet.Amount = 0;
        } 
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet

            if (BetAmount <= Cash)
            {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
                UpdateLabels();
                return true;
            }
            else
            {
                return false;
            }

            
        }
        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels

            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
