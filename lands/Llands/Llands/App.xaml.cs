using Llands.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Llands
{

    public partial class App : Application
    {
        #region Constructors
        public App()
        {
            InitializeComponent();
            //Hago de LoginPage mi Página de Inicio
            MainPage = new NavigationPage(new LoginPage());
        }
        #endregion Constructors

        #region Metodos
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion Metodos
    }
}
