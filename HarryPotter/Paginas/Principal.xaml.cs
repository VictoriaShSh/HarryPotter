using HarryPotter.BaseDatos;
using HarryPotter.UControl;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HarryPotter.Paginas
{
    /// <summary>
    /// Pagina principal de la aplicacion
    /// </summary>
    public partial class Principal : Page
    {
        Mas mas;
        BBDD BaseDatos;

        /// <summary>
        /// Constructor de la pagina
        /// </summary>

        public Principal()
        {
            InitializeComponent();
            mas = usercon;
            mas.Clic += Mas_ClaseClick;
            mas.Clic += Mas_SombreroClick;
        }

        /// <summary>
        /// Manejador del evento Clic del boton "Clase" del user control Mas
        /// </summary>
        /// <param name="tipoPagina">Tipo de la pagina que se debe mostrar</param>
        private void Mas_ClaseClick(Type tipoPagina)
        {
            if (tipoPagina == typeof(Clase))
            {
                Clase clase = new Clase();
                NavigationService.Navigate(clase);
            }
        }

        /// <summary>
        /// Manejador del evento Clic del boton "Sombrero Seleccionador" del user control Mas
        /// </summary>
        /// <param name="tipoPagina">Tipo de la pagina que se debe mostrar</param>
        private void Mas_SombreroClick(Type tipoPagina)
        {
            if (tipoPagina == typeof(SombreroSeleccionador))
            {
                SombreroSeleccionador sombrero = new SombreroSeleccionador();
                NavigationService.Navigate(sombrero);
            }
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
        /// Evento que se ejecuta cuando se hace click en el boton de Gryffindor
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Gryffindor_Click(object sender, RoutedEventArgs e)
        {
            Gryffindor gryffindor = new Gryffindor();
            this.NavigationService.Navigate(gryffindor);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton de Gryffindor
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Slytherin_Click(object sender, RoutedEventArgs e)
        {
            Slytherin slytherin = new Slytherin();
            this.NavigationService.Navigate(slytherin);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton de Hufflepuff
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Hufflepuff_Click(object sender, RoutedEventArgs e)
        {
            Hufflepuff hufflepuff = new Hufflepuff();
            this.NavigationService.Navigate(hufflepuff);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton de Ravenclaw
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Ravenclaw_Click(object sender, RoutedEventArgs e)
        {
            Ravenclaw ravenclaw = new Ravenclaw();
            this.NavigationService.Navigate(ravenclaw);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Cerrar Sesion"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Sesion_Click(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.NavigationService.Navigate(inicio);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Registrar Usuario"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            // Navega hacia la página de registro
            Registro registro = new Registro();
            this.NavigationService.Navigate(registro);

        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Salir"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Ayuda"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void Ayuda_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bienvenido a la app de Harry Potter donde puedes averiguar información sobre tus personajes preferidos de la saga " +
                            "asi como, aprender los múltiples hechizos y sus utilidades.\r\nComo puedes observar esta pagina tiene cuatro botones" +
                            "con las cuatro casas de Hogwarts, si ya tienes claro cual es tu casa solo pulsa sobre el escudo de la casa, si no es asi " +
                            "observaras que arriba a la derecha hay un botón de “Mas”, si pulsas sobre el aparecerá una ventana con dos botones, " +
                            "en uno de ellos pone “Sombrero Seleccionador” y si pulsas te llevara a la pagina donde se te asignara una casa de Hogwarts.\r\n" +
                            "Si deseas aprender hechizos, solo tienes que volver a pulsar sobre el botón “Mas” Y después al botón de “Clase” que " +
                            "te llevara a clase donde podrás aprender todos los hechizos que quieras.\r\n" + "Esta aplicación es exclusiva de uso educativo.\r\n" +
                            "¡A disfrutar!");
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Borrar Usuario"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void BorrarUs_Click(object sender, RoutedEventArgs e)
        {
            Borrar borrar = new Borrar();
            this.NavigationService.Navigate(borrar);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Ver Uusarios"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void VerUs_Click(object sender, RoutedEventArgs e)
        {
            BaseDatos = new BBDD();
            string usuarios = BaseDatos.MostrarUsuarios();
            MessageBox.Show(usuarios.ToString());
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en el boton "Registrar Administrador"
        /// </summary>
        /// <param name="sender">El objeto que envia el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void RegistrarAd_Click(object sender, RoutedEventArgs e)
        {
            // Navega hacia la página de registro
            RegistroAdmin registroAd = new RegistroAdmin();
            this.NavigationService.Navigate(registroAd);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SombreroSeleccionador sombrero = new SombreroSeleccionador();
            NavigationService.Navigate(sombrero);
        }
    }
}

