using yourTraining.View;
using yourTraining.Models;

namespace yourTraining
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnSleep()
        {
            (Current.MainPage as FichaTreinoPage)?.SaveFichaTreino();
        }
    }
}
