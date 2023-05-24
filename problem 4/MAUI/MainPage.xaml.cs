using Microsoft.Maui.Controls;

namespace MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnShowTableClicked(object sender, EventArgs e)
        {
            if (int.TryParse(numberEntry.Text, out int number) && number >= -50 && number <= 50)
            {
                tableLayout.Children.Clear();

                for (int i = 1; i <= 12; i++)
                {
                    Label label = new Label
                    {
                        Text = $"{number} x {i} = {number * i}",
                        FontSize = 20,
                        Margin = new Thickness(0, 5),
                    };

                    tableLayout.Children.Add(label);
                }

                scrollView.ScrollToAsync(tableLayout, ScrollToPosition.Start, true);
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter a valid number between -50 and 50.", "OK");
            }
        }
    }
}
