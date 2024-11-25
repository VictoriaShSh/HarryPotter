using HarryPotter.Paginas;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HarryPotter.UControl
{
    /// <summary>
    /// Clase que define el User Control
    /// </summary>
    public partial class Mas : UserControl
    {
        /// <summary>
        /// Delegado que se utiliza para representar un metodo que no devuelve ningun valor y que toma un argumento de tipo Type
        /// </summary>
        public delegate void Action(Type tipo);

        /// <summary>
        /// Delegado utilizado para el evento Clic.
        /// </summary>
        public event Action<Type>? Clic;

        /// <summary>
        /// Constructor de la clase Mas.
        /// </summary>
        public Mas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador del evento Click del botón "Clase".
        /// </summary>
        /// <param name="sender">Objeto que envía el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Clase_Click(object sender, RoutedEventArgs e)
        {
            Clic?.Invoke(typeof(Clase));
        }

        /// <summary>
        /// Manejador del evento Click del botón "Sombrero Seleccionador".
        /// </summary>
        /// <param name="sender">Objeto que envía el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Sombrero_Click(object sender, RoutedEventArgs e)
        {
            Clic?.Invoke(typeof(SombreroSeleccionador));
        }
    }
}



