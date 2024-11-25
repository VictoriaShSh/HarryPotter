using HarryPotter.BaseDatos;
using System.Windows;
using System.Windows.Controls;

namespace HarryPotter.Paginas
{
    /// <summary>
    /// Pagina que se utliza para registrar nuevos Administradores
    /// </summary>
    public partial class RegistroAdmin : Page
    {
        private BBDD BD;

        /// <summary>
        /// Constructor de la pagina
        /// </summary>
        public RegistroAdmin()
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
            Window? window = Window.GetWindow(this);
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
        /// Evento que se ejecuta cuando se hace click en el boton "Registrar"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            BD = new BBDD();

            if (Usuario.Text == string.Empty || Nombre.Text == string.Empty || Contraseña.Password == string.Empty)
            {
                Error.Content = "Debes rellenar todos los campos";
            }
            else
            {
                BD.Añadir(Nombre.Text, Usuario.Text, Contraseña.Password, 1);

                Principal principal = new Principal();
                this.NavigationService.Navigate(principal);
            }
        }
    }
}

