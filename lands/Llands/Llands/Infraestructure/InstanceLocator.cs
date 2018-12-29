using System;
using System.Collections.Generic;
using System.Text;

namespace Llands.Infraestructure
{
    /*
     Creo esta clase InstaceLocator donde referencio un objeto llamado "Main" del tipo "MainViewModel". 
     Este objeto Main lo instancio dentro del contructor de InstanceLocator.
     Esto significa que cuando yo ejecute la aplicación, va a pasar por el DICCIONARIO DE RECURSOS (App.xaml), donde va a decirle que
     InstanceLocator lo encuentra en Infra que se encuentra en Lands/Infrestructure, donce dentro de Infraestructure va a encontrar 
     la clase InstanceLocator, y la clase InstanceLocator la va a llamar "Locator".
     Ahora debo hacer "BindingContext="{Binding Main, Source={StaticResource Locator}}"" para bindear la LoginPage con InstanceLocator
    */
    using ViewModels;
    /// <summary>
    /// Esta clase que nos instancia los "locators"
    /// </summary>
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }

        #endregion Properties

        #region Constructores
        public InstanceLocator()
        {
            this.Main = new MainViewModel(); // Esto es un patrón de diseño que se llama el "Patron locator"
            // Esto nos sirve para que podamos conectar la página Login con la MainViewModel.
        }
        #endregion Constructores
    }


}
