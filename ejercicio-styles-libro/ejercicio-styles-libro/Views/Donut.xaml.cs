using ejercicio_styles_libro.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ejercicio_styles_libro
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Donut : Page
    {
        public Donut()
        {
            this.InitializeComponent();
           
        }
        private void Button_ClickDonuts(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Donut));
        }

        private void Button_ClickCoffee(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Coffee));
        }
        private void Button_ClickSchedule(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Schedule));
        }
        private void Button_ClickComplete(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Complete));
        }
    }
}
