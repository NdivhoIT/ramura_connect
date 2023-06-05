using RC_.Pages;

namespace RC_;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    async void OnOpenWebButtonClicked(System.Object sender, System.EventArgs e)
    {
        await Browser.OpenAsync("https://www.devexpress.com/maui/");
    }

}
