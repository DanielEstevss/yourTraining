namespace yourTraining.View;

public partial class mainPage : ContentPage
{
	public mainPage()
	{
		InitializeComponent();
	}

	// M�todo click que leva a pr�xima p�gina
    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {		
		await Navigation.PushAsync(new ExerciciosPage());
    }
}