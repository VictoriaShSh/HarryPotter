using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HarryPotter.Paginas
{
    /// <summary>
    /// Clase que se utiliza para asignar una casa de Hogwarts
    /// </summary>
    public partial class SombreroSeleccionador : Page
    {
        /// <summary>
        /// Constructor de la pagina
        /// </summary>
        public SombreroSeleccionador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga la pagina
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.WindowState = WindowState.Maximized;
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton del Sombrero
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private async void Sombrero_Click(object sender, RoutedEventArgs e)
        {
            casa.Visibility = Visibility.Hidden;
            casaTexto.Content = " ";

            pulsame.Visibility = Visibility.Hidden;
            await Task.Delay(2000);
            pensar.Visibility = Visibility.Visible;
            await Task.Delay(3000);
            pensar.Visibility = Visibility.Hidden;
            await Task.Delay(1000);

            BitmapImage[] images = new BitmapImage[]
            {
                new BitmapImage(new Uri("pack://application:,,,/Resources/H.png")),
                new BitmapImage(new Uri("pack://application:,,,/Resources/S.png")),
                new BitmapImage(new Uri("pack://application:,,,/Resources/R.png")),
                new BitmapImage(new Uri("pack://application:,,,/Resources/G.png")),
            };

            Dictionary<BitmapImage, string> CasaTexto = new Dictionary<BitmapImage, string>()
{
                {images[0], "Hufflepuff !!!"},
                {images[1], "Slytherin !!!"},
                {images[2], "Ravenclaw !!!"},
                {images[3], "Gryffindor !!!"},
            };

            Random random = new Random();
            int index = random.Next(images.Length);
            casa.Source = images[index];
            casa.Visibility = Visibility.Visible;

            string texto = CasaTexto[images[index]];
            casaTexto.Content = texto;

            await Task.Delay(3000);
            pulsame.Visibility = Visibility.Visible;
        }
    }
}
