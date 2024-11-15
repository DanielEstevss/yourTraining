using System.Collections.ObjectModel;
using yourTraining.Models;

namespace yourTraining.View;

public partial class ExerciciosPage : ContentPage
{
	public Config Exercicios { get; set; }
	public ObservableCollection<Exercicio> ExerciciosSelecionados { get; set; } = new ObservableCollection<Exercicio>();	

	public ExerciciosPage()
	{
		InitializeComponent();

		Exercicios = new Config();

		BindingContext = Exercicios;
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		var exercicioSelecionado = e.CurrentSelection.FirstOrDefault() as Exercicio;

		if (exercicioSelecionado != null)
		{
			// Adicionar exercício a ficha de treino
			ExerciciosSelecionados.Add(exercicioSelecionado);

			// Exibir mensagem de confirmação
			DisplayAlert("Exercício Selecionado", exercicioSelecionado.Nome, "OK");

			// Limpar a selecão
			((CollectionView)sender).SelectedItem = null;
		}
    }

    private async void btnFichaTreino_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FichaTreinoPage(ExerciciosSelecionados));
    }
}