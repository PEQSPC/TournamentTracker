using System;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary.DataAcess;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }



        private void btn_CreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidadeForm())
            {
                PrizeModel model = new PrizeModel(PlaceNameValue.Text, placeNumberValue.Text, PrizeAmountValue.Text, PrizePercentageValue.Text);


                GlobalConfig.Connection.CreatePrize(model);


                PlaceNameValue.Text = "";
                placeNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";

               // MessageBox.Show(model.Id.ToString());

            }
            else
            {
                MessageBox.Show("This Form has invalid information");
            }
        }

        private bool ValidadeForm()
        {
            bool output = true;
            int placeNumber = 0;

            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                return output == false;
            }

            if (PlaceNameValue.Text.Length == 0)
            {
                return output = false;
            }

            decimal prizeAmmount = 0;
            double prizePercentage = 0;

            bool prizeAmmountValid = decimal.TryParse(placeNumberValue.Text, out prizeAmmount);
            bool prizePercentageValid = double.TryParse(placeNumberValue.Text, out prizePercentage);

            if (prizeAmmountValid == false || prizePercentageValid == false)
            {
                return output == false;
            }

            if (prizeAmmount <= 0&& prizePercentage <= 0)
            {
                return output == false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                return output == false;
            }

            return output;
        }
    }
}
