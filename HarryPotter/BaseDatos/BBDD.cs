using System;
using System.Data.SQLite;
using System.Text;
using System.Windows;

namespace HarryPotter.BaseDatos
{
    /// <summary>
    /// Clase encargada de gestionar la base de datos de la aplicacion
    /// </summary>
    internal class BBDD
    {
        private SQLiteCommand comando;
        private SQLiteDataReader lector;
        private SQLiteConnection conexion;
        private bool esAdministrador;

        /// <summary>
        /// Establece la conexion a la base de datos.
        /// </summary>
        public void Conexion()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
            else
            {
                try
                {
                    conexion = new SQLiteConnection("Data Source=./Resources/HPDB.db;Version=3;");
                    conexion.Open();
                }
                catch (SQLiteException sqle)
                {
                    MessageBox.Show(sqle.Message);
                }
            }
        }

        /// <summary>
        /// Conexion a la base de datos a traves de un usuario y una contraseña
        /// </summary>
        /// <param name="usuario">Nombre deL usuario</param>
        /// <param name="contraseña">Contraseña del usuario</param>
        /// <returns>Devuelve verdadero si se ha podido conectar, falso en caso contrario</returns>
        public bool Conectar(string usuario, string contraseña)
        {
            Conexion();

            comando = new SQLiteCommand("SELECT * FROM HP WHERE Usuario=@usuario AND Contraseña=@contraseña", conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            try
            {
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    esAdministrador = Convert.ToBoolean(lector[3]);
                    return true;
                }
                return false;
            }
            catch (SQLiteException)
            {
                return false;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        /// <summary>
        /// Añade un nuevo usuario a la base de datos
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="usuario">Alias del usuario</param>
        /// <param name="contraseña">Contraseña del usuario</param>
        /// <param name="admin">Indica si el usuario es administrador</param>
        public void Añadir(string nombre, string usuario, string contraseña, int admin)
        {
            Conexion();
            comando = new SQLiteCommand("INSERT INTO HP(Nombre, Usuario, Contraseña, Admin) VALUES (@nombre, @usuario, @contraseña, @admin)", conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@admin", admin);

            try
            {
                var transaccion = conexion.BeginTransaction();
                comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Borra un usuario de la base de datos a partir de su nombre de usuario
        /// </summary>
        /// <param name="usuario">El nombre de usuario del usuario que se quiere borrar</param>
        public void Borrar(string usuario)
        {
            Conexion();
            comando = new SQLiteCommand("DELETE FROM HP WHERE Usuario=@usuario;", conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                var transaccion = conexion.BeginTransaction();
                comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Muestra todos los nombres de usuario de la base de datos
        /// </summary>
        public string MostrarUsuarios()
        {
            Conexion();
            StringBuilder usuarios = new StringBuilder();
            comando = new SQLiteCommand("SELECT Usuario FROM HP", conexion);
            try
            {
                using (SQLiteDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        usuarios.AppendLine(lector.GetString(0));
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message);
            }
            return usuarios.ToString();
            lector.Close();
            conexion.Close();
        }


        /// <summary>
        /// Devuelve si el usuario actual es administrador
        /// </summary>
        /// <returns>Devuelve verdadero si el usuario es administrador, falso en caso contrario</returns>
        public bool EsAdministrador()
        {
            return esAdministrador;
        }
    }
}