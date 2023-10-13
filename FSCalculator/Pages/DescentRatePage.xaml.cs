using System.Reflection.Metadata.Ecma335;

namespace FSCalculator.Pages;

public partial class DescentRatePage : ContentPage
{
	public DescentRatePage()
	{
		InitializeComponent();
	}

	public void OnCalculateButtonClicked(object sender, EventArgs args)
	{
        double.TryParse(groundSpeed.Text, out double gs);
		double.TryParse(windAmount.Text, out double wind);

		if (gs < 0 || wind < 0) {
			DisplayAlert("Alert", "Wind and groundspeed need to be 0 or higher", "OK");

			return;
		}

		double result = 3 * (gs + wind) / 60 * 100;

		resultLabel.Text = $"{result} fpm";
    }
}