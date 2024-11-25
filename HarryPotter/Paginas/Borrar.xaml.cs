using HarryPotter.BaseDatos;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HarryPotter.Paginas
{
    /// <summary>
    /// Clase que se utiliza para barrar Usuarios
    /// </summary>
    public partial class Borrar : Page
    {
        private BBDD DatBas;
        private List<string> usuarios;

        /// <summary>
        /// Constructor de la pagina
        /// </summary>
        public Borrar()
        {
            InitializeComponent();
            usuarios = new List<string>();
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

            CargarUsuarios();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Salir"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Eliminar"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            DatBas = new BBDD();

            if (Usuario.SelectedItem != null)
            {
                string usuarioSeleccionado = Usuario.SelectedItem.ToString();
                DatBas.Borrar(usuarioSeleccionado);

                Principal principal = new Principal();
                this.NavigationService.Navigate(principal);
            }
            else
            {
                Error.Content = "Debes seleccionar un usuario para borrarlo";
            }
        }

        /// <summary>
        /// Metodo que se encarga de mostrar los usuarios de la base de datos
        /// </summary>
        private void CargarUsuarios()
        {
            DatBas = new BBDD();
            string usuario = DatBas.MostrarUsuarios();

            if (!string.IsNullOrEmpty(usuario))
            {
                string[] usuarios = usuario.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string usu in usuarios)
                {
                    Usuario.Items.Add(usu);
                }
            }
            else
            {
                Error.Content = "Error al obtener los usuarios";
            }
        }

    }
}
