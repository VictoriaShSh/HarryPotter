using HarryPotter.BaseDatos;
using System.Windows;
using System.Windows.Controls;

namespace HarryPotter.Paginas
{
    /// <summary>
    /// Clase que muestra la primera pagina de la aplicacion
    /// </summary>
    public partial class Inicio : Page
    {
        private BBDD BaseDatos = new BBDD();
        Principal principal = new Principal();

        /// <summary>
        /// Constructor de la pagina
        /// </summary>
        public Inicio()
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
        /// Evento que se ejecuta cuando se hace click en el boton "Salir"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Acceder"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Acceder_Click(object sender, RoutedEventArgs e)
        {
            if (BaseDatos.Conectar(Usuario.Text, Contraseña.Password))
            {
                if (BaseDatos.EsAdministrador())
                {
                    principal.Administrador.Visibility = Visibility.Visible;
                }
                else
                {
                    principal.Administrador.Visibility = Visibility.Hidden;
                }
                this.NavigationService.Navigate(principal);
            }
            else
            {
                Contraseña.Password = "";
                Error.Content = "Usuario o Contraseña Incorrectos";
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Registrar"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Registro_Click(object sender, RoutedEventArgs e)
        {
            Registro registro = new Registro();
            this.NavigationService.Navigate(registro);
        }
    }
}
