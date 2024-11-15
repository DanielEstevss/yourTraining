using System.Collections.ObjectModel;
using yourTraining.Models;
using Microsoft.Maui.Storage;
using System.Text.Json;

namespace yourTraining.View;

public partial class FichaTreinoPage : ContentPage
{
	public ObservableCollection<Exercicio> ExerciciosSelecionados { get; set; }

	public FichaTreinoPage(ObservableCollection<Exercicio> exerciciosSelecionados)
	{
		InitializeComponent();

        CarregarFichaTreino();

        ExerciciosSelecionados = exerciciosSelecionados;
		

		BindingContext = this;
	}

    private void btnLimpar_Clicked(object sender, EventArgs e)
    {
		ExerciciosSelecionados.Clear();
		SaveFichaTreino();
    }

	private void CarregarFichaTreino()
	{
		var saveFichaTreino = Preferences.Get("FichaTreinoData", string.Empty);

		if (!string.IsNullOrEmpty(saveFichaTreino))
		{
			ExerciciosSelecionados = JsonSerializer.Deserialize<ObservableCollection<Exercicio>>(saveFichaTreino) ?? new ObservableCollection<Exercicio>();
		}

		else
		{
			ExerciciosSelecionados = new ObservableCollection<Exercicio>();
		}
	}

	public void SaveFichaTreino()
	{
		var fichaTreinoJson = JsonSerializer.Serialize(ExerciciosSelecionados);
		Preferences.Set("FichaTreinoData", fichaTreinoJson);
	}

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
		SaveFichaTreino();
    }
}