namespace yourTraining.View;

public partial class mainPage : ContentPage
{
	public mainPage()
	{
		InitializeComponent();
	}

	// Método click que leva a próxima página
    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {		
		await Navigation.PushAsync(new ExerciciosPage());
    }
}