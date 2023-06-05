using RC_.Pages;

namespace RC_;
public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	async void btnReg_Clicked(Object sender, EventArgs e)
    {
        //await Browser.OpenAsync("https://www.devexpress.com/maui/");
        await Navigation.PushAsync(new Reg());
    }
}

