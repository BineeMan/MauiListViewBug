using MauiApp4.Model;

namespace MauiApp4;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

	}
}

