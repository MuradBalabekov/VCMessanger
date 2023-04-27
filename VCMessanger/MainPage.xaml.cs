using VCMessanger.ViewModels;

namespace VCMessanger;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        Routing.RegisterRoute("chatPage", typeof(ChatPage));
        Routing.RegisterRoute("settingPage", typeof(SettingPage));
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		await Shell.Current.GoToAsync("settingPage");
    }
}

