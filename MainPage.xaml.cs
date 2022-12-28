namespace SparePartsTool;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		string LoginDate = DateTime.Today.ToString("dd/MM/yyyy");
		if (LoginDate!= Preferences.Default.Get("SAG","Expired"))
		{
            Preferences.Default.Set("SAG", "Expired");
        }
		
        
    }
}
