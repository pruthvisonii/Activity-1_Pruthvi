using Microsoft.Maui.Controls;

namespace MAUI
{
    public partial class MainPage : ContentPage
    {
        private const string CorrectPassword = "password";
        private int remainingAttempts = 5;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string enteredPassword = passwordEntry.Text;
            if (enteredPassword == CorrectPassword)
            {
                resultLabel.Text = "Welcome!";
            }
            else
            {
                remainingAttempts--;
                if (remainingAttempts > 0)
                {
                    resultLabel.Text = $"Incorrect password. {remainingAttempts} attempts remaining.";
                }
                else
                {
                    resultLabel.Text = "You have been locked out.";
                    passwordEntry.IsEnabled = false;
                }
            }
        }
    }
}


