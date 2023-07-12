namespace MauiApp3;

public partial class Ayarlarr : ContentPage
{
	public Ayarlarr()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		if (e.Value)
			Application.Current.UserAppTheme = AppTheme.Dark;
		else
            Application.Current.UserAppTheme = AppTheme.Light;

    }
}