using CommunityToolkit.Maui.Views;

namespace SKLottieViewBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        this.ShowPopup(new MainPopup());
    }
}