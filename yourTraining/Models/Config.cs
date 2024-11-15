using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourTraining.Models;

public class Config
{
    // Crição e inicialização das Lists
    public List<Exercicio> ListaExerciciosPeito { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosCosta { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosTrapezio { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosOmbro { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosBiceps { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosTriceps { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosPerna { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosGluteo { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosPanturrilha { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosAbdomen { get; set; } = new List<Exercicio>();
    public List<Exercicio> ListaExerciciosCardio { get; set; } = new List<Exercicio>();

    public List<Exercicio> ExerciciosSelecionados { get; set; } = new List<Exercicio>();

    // Construtor para a adição dos exercícios disponiveis 
    public Config()
    {
        // Peito
        ListaExerciciosPeito.Add(new Exercicio{Nome = "Supino Reto", GrupoMuscular = "Peito"});
        ListaExerciciosPeito.Add(new Exercicio { Nome = "Supino Inclinado", GrupoMuscular = "Peito"});
        ListaExerciciosPeito.Add(new Exercicio { Nome = "Voador", GrupoMuscular = "Peito"});
        ListaExerciciosPeito.Add(new Exercicio { Nome = "Crossover Polia Alta", GrupoMuscular = "Peito"});
        ListaExerciciosPeito.Add(new Exercicio { Nome = "Crossover Polia Baixa", GrupoMuscular = "Peito"});

        // Costa
        ListaExerciciosCosta.Add(new Exercicio { Nome = "Puxada Frontal Aberta", GrupoMuscular = "Costa"});
        ListaExerciciosCosta.Add(new Exercicio { Nome = "Remada Curvada", GrupoMuscular = "Costa"});
        ListaExerciciosCosta.Add(new Exercicio { Nome = "Remada Baixa", GrupoMuscular = "Costa"});
        ListaExerciciosCosta.Add(new Exercicio { Nome = "Pulldown", GrupoMuscular = "Costa"});
        ListaExerciciosCosta.Add(new Exercicio { Nome = "Cruxifixo Invertido", GrupoMuscular = "Costa"});

        // Trapézio
        ListaExerciciosTrapezio.Add(new Exercicio { Nome = "Encolhimeto", GrupoMuscular = "Trapézio"});
        ListaExerciciosTrapezio.Add(new Exercicio { Nome = "Remada Alta", GrupoMuscular = "Trapézio"});

        // Ombro
        ListaExerciciosOmbro.Add(new Exercicio { Nome = "Elevação Lateral", GrupoMuscular = "Ombro"});
        ListaExerciciosOmbro.Add(new Exercicio { Nome = "Desenvolvimento", GrupoMuscular = "Ombro"});
        ListaExerciciosOmbro.Add(new Exercicio { Nome = "Face Pull", GrupoMuscular = "Ombro"});

        // Bíceps
        ListaExerciciosBiceps.Add(new Exercicio { Nome = "Rosca Scott", GrupoMuscular = "Bícepis"});
        ListaExerciciosBiceps.Add(new Exercicio { Nome = "Rosca Direta", GrupoMuscular = "Bícepis"});
        ListaExerciciosBiceps.Add(new Exercicio { Nome = "Rosca Martelo", GrupoMuscular = "Bícepis"});

        // Tríceps
        ListaExerciciosTriceps.Add(new Exercicio { Nome = "Tríceps na Polia", GrupoMuscular = "Tríceps"});
        ListaExerciciosTriceps.Add(new Exercicio { Nome = "Tríceps Francês", GrupoMuscular = "Tríceps"});
        ListaExerciciosTriceps.Add(new Exercicio { Nome = "Tríceps Testa", GrupoMuscular = "Tríceps"});

        // Perna
        ListaExerciciosPerna.Add(new Exercicio { Nome = "Cadeira Extensora", GrupoMuscular = "Perna" });
        ListaExerciciosPerna.Add(new Exercicio { Nome = "Agachamento no Smith", GrupoMuscular = "Perna" });
        ListaExerciciosPerna.Add(new Exercicio { Nome = "Leg Press", GrupoMuscular = "Perna" });
        ListaExerciciosPerna.Add(new Exercicio { Nome = "Mesa Flexora", GrupoMuscular = "Perna"});
        ListaExerciciosPerna.Add(new Exercicio { Nome = "Sitff", GrupoMuscular = "Perna" });

        // Glúteo
        ListaExerciciosGluteo.Add(new Exercicio { Nome = "Elevação Pélvica", GrupoMuscular = "Glúteo" });
        ListaExerciciosGluteo.Add(new Exercicio { Nome = "Cadeira Abdutora", GrupoMuscular = "Glúteo" });

        // Panturrilha
        ListaExerciciosPanturrilha.Add(new Exercicio { Nome = "Panturrilha no Smith", GrupoMuscular = "Panturrilha" });
        ListaExerciciosPanturrilha.Add(new Exercicio { Nome = "Panturrilha na Máquina", GrupoMuscular = "Panturrilha" });

        // Abdomen
        ListaExerciciosAbdomen.Add(new Exercicio { Nome = "Abdominal Supra", GrupoMuscular = "Abdomen" });
        ListaExerciciosAbdomen.Add(new Exercicio { Nome = "Elevação de Pernas", GrupoMuscular = "Abdomen" });
        ListaExerciciosAbdomen.Add(new Exercicio { Nome = "Prancha", GrupoMuscular = "Abdomen" });

        // Cardio
        ListaExerciciosCardio.Add(new Exercicio { Nome = "Esteira", GrupoMuscular = "Cardio"});
        ListaExerciciosCardio.Add(new Exercicio { Nome = "Bicicleta", GrupoMuscular = "Cardio"});
        ListaExerciciosCardio.Add(new Exercicio { Nome = "Escadas", GrupoMuscular = "Cardio"});
    }

    // Método para adição do exercício na ficha de treino
    public void AdicionarExercicoFichaTreino(Exercicio exercicio)
    {
        ExerciciosSelecionados.Add(exercicio);
    }

    // Método para remoção do exercício da ficha de treino
    public void ExluirExercicioFichaTreino(Exercicio exercicio)
    {
        ExerciciosSelecionados.Remove(exercicio);
    }
}
