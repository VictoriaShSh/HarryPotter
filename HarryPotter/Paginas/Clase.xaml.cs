using HarryPotter.API;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HarryPotter.Paginas
{
    /// <summary>
    /// Clase que se utiliza para aprender hechizos
    /// </summary>
    public partial class Clase : Page
    {
        private Consultas api;

        /// <summary>
        /// Constructor de la pagina
        /// </summary>
        public Clase()
        {
            InitializeComponent();
            api = new Consultas();

            mostrarHechizos();
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
        /// Metodo que muestra los nombres de los hechizos
        /// </summary>
        private async void mostrarHechizos()
        {
            List<string> hechizos = await api.ObtenerHechizos();

            foreach (string hech in hechizos)
            {
                Hechizos.Items.Add(hech);
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se selecciona un hechizo
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private async void Hechizos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Descripcion.Clear();
            int posicion = Hechizos.SelectedIndex;
            string descripcion = await api.ObtenerDescripcionHechizo(posicion);
            Descripcion.Text = descripcion;
        }
    }
}