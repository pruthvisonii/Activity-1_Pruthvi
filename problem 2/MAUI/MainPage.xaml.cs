using Microsoft.Maui.Controls;

namespace MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCheckClicked(object sender, EventArgs e)
        {
            string input = letterEntry.Text.ToLower();

            if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
            {
                resultLabel.Text = "vowel";
            }
            else
            {
                resultLabel.Text = "not a vowel";
            }
        }
    }
}
