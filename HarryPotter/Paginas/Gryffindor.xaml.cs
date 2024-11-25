using HarryPotter.API;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HarryPotter.Paginas
{
    /// <summary>
    /// Clase que se utiliza para conocer a los personajes de Gryffindor
    /// </summary>
    public partial class Gryffindor : Page
    {
        private Consultas api;
        /// <summary>
        /// Constructor de la pagina
        /// </summary>
        public Gryffindor()
        {
            InitializeComponent();
            api = new Consultas();
            mostrarCasa();
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
        /// Metodo asincrono que muestra la lista de los personajes
        /// </summary>
        private async void mostrarCasa()
        {
            string casa = "Gryffindor";
            List<string> personajes = await api.obtenerPersonajes(casa);

            foreach (string per in personajes)
            {
                Personajes.Items.Add(per);
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace selecciona un personaje de la casa
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private async void Personajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Personajes.SelectedItem != null)
            {
                string personaje = Personajes.SelectedItem.ToString();
                Dictionary<string, string> datos = await api.obtenerDatosPersonaje(personaje);

                try
                {
                    Imagen.Source = new BitmapImage(new Uri(datos["image"]));
                }
                catch (Exception)
                {
                    Imagen.Source = null;
                }

                Cumpleaños.Text = datos.ContainsKey("dateOfBirth") ? datos["dateOfBirth"] : "Informacion no disponible";
                Descendiente.Text = datos.ContainsKey("ancestry") ? datos["ancestry"] : "Informacion no disponible";
                Patronus.Text = datos.ContainsKey("patronus") ? datos["patronus"] : "Informacion no disponible";
                Madera.Text = datos.ContainsKey("madera") ? datos["madera"] : "Informacion no disponible";
                Nucleo.Text = datos.ContainsKey("nucleo") ? datos["nucleo"] : "Informacion no disponible";
                Longitud.Text = datos.ContainsKey("longitud") ? datos["longitud"] : "Informacion no disponible";

                if (datos.ContainsKey("type"))
                {
                    if (datos["type"] == "Profesor")
                    {
                        Ocupacion.Text = "Profesor";
                    }
                    else
                    {
                        Ocupacion.Text = "Estudiante";
                    }
                }
            }
        }
    }
}
