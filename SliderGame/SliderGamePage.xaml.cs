using Xamarin.Forms;
using System;

namespace SliderGame
{
    public partial class SliderGamePage : ContentPage
    {
        public SliderGamePage()
        {
            InitializeComponent();
        }

        void OnSliderValueChange(object sender, ValueChangedEventArgs args){
            double value = slider.Value;
            int myVal = Convert.ToInt32(value);
            if (value > 30)
            {
                DisplayAlert("Good", "Your score is over 30", "OK");
            }
            else
            {
                playerScore.Text = string.Format("Score:{0}", myVal);
            }
        }

        void ResetButton(object sender, EventArgs e){
            slider.Value = 0;
            playerScore.Text = "Score:0";
        }

      
    }
}
