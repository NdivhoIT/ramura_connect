namespace RC_.Pages;

public partial class Reg : ContentPage
{
	public Reg()
	{
		InitializeComponent();
	}

    

    async void OnRegisterClicked(Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Home());
    }
}