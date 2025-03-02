namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = newAppAhell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        
        }
    }
}