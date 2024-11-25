using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HarryPotter.API
{
    /// <summary>
    /// Clase que se encarga de realizar consultas a la API
    /// </summary>
    public class Consultas
    {
        private string? respuesta;
        private JsonDocument? jsonHP;

        /// <summary>
        /// Obtiene una lista de nombres de personajes de la casa
        /// </summary>
        /// <param name="casa">La casa de Hogwarts de la que se quieren obtener los personajes</param>
        /// <returns>Una lista de nombres de los personajes de la casa</returns>
        public async Task<List<string>> obtenerPersonajes(string casa)
        {
            var direccion = new Uri($"https://hp-api.onrender.com/api/characters/house/{casa}");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                using (var response = await httpClient.GetAsync(""))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        respuesta = await response.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(respuesta))
                        {
                            jsonHP = JsonDocument.Parse(respuesta);
                            int cantidad = jsonHP.RootElement.GetArrayLength();

                            List<string> personajes = new List<string>();
                            for (int i = 0; i < cantidad; i++)
                            {
                                string nombre = jsonHP.RootElement[i].GetProperty("name").ToString();
                                personajes.Add(nombre);
                            }
                            return personajes;
                        }
                    }
                }
            }
            throw new Exception();
        }


        /// <summary>
        /// Obtiene los datos de un personaje especifico
        /// </summary>
        /// <param name="personaje">Nombre del personaje</param>
        /// <returns>Diccionario con los datos del personaje</returns>
        public async Task<Dictionary<string, string>> obtenerDatosPersonaje(string personaje)
        {
            var direccion = new Uri($"https://hp-api.onrender.com/api/characters?name={personaje}");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                using (var response = await httpClient.GetAsync(""))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        respuesta = await response.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(respuesta))
                        {
                            jsonHP = JsonDocument.Parse(respuesta);
                            int cantidad = jsonHP.RootElement.GetArrayLength();

                            for (int i = 0; i < cantidad; i++)
                            {
                                string nombre = jsonHP.RootElement[i].GetProperty("name").ToString();
                                if (nombre.ToLower() == personaje.ToLower())
                                {
                                    Dictionary<string, string> datos = new Dictionary<string, string>();

                                    string imagen = jsonHP.RootElement[i].GetProperty("image").ToString();
                                    datos.Add("image", imagen);

                                    string fechaNacimiento = jsonHP.RootElement[i].GetProperty("dateOfBirth").ToString();
                                    if (fechaNacimiento != "")
                                    {
                                        datos.Add("dateOfBirth", fechaNacimiento);
                                    }

                                    string ancestro = jsonHP.RootElement[i].GetProperty("ancestry").ToString();
                                    if (ancestro != "")
                                    {
                                        datos.Add("ancestry", ancestro);
                                    }

                                    string patronus = jsonHP.RootElement[i].GetProperty("patronus").ToString();
                                    if (patronus != "")
                                    {
                                        datos.Add("patronus", patronus);
                                    }

                                    var varita = jsonHP.RootElement[i].GetProperty("wand");
                                    if (varita.ValueKind != JsonValueKind.Null)
                                    {
                                        string madera = varita.GetProperty("wood").ToString();
                                        if (madera != "")
                                        {
                                            datos.Add("madera", madera);
                                        }
                                        string nucleo = varita.GetProperty("core").ToString();
                                        if (nucleo != "")
                                        {
                                            datos.Add("nucleo", nucleo);
                                        }
                                        string longitud = varita.GetProperty("length").ToString();
                                        if (longitud != "")
                                        {
                                            datos.Add("longitud", longitud);
                                        }
                                    }
                                    string esProfesor = jsonHP.RootElement[i].GetProperty("hogwartsStaff").ToString();
                                    if (esProfesor == "True")
                                    {
                                        datos.Add("type", "Profesor");
                                    }
                                    else
                                    {
                                        datos.Add("type", "Estudiante");
                                    }

                                    return datos;
                                }
                            }
                        }
                    }
                }
            }
            throw new Exception("No se encontró el personaje solicitado");
        }

        /// <summary>
        /// Obtiene una lista de hechizos a traves de la API
        /// </summary>
        /// <returns>Una lista con los nombres de los hechizos</returns>
        public async Task<List<string>> ObtenerHechizos()
        {
            var direccion = new Uri("https://hp-api.onrender.com/api/spells");

            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                using (var response = await httpClient.GetAsync(""))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var respuesta = await response.Content.ReadAsStringAsync();

                        if (!string.IsNullOrEmpty(respuesta))
                        {
                            var jsonHP = JsonDocument.Parse(respuesta);
                            int cantidad = jsonHP.RootElement.GetArrayLength();

                            List<string> hechizos = new List<string>();
                            for (int i = 0; i < cantidad; i++)
                            {
                                string nombre = jsonHP.RootElement[i].GetProperty("name").ToString();
                                hechizos.Add(nombre);
                            }

                            return hechizos;
                        }
                    }
                }
            }
            throw new Exception("No se pudo obtener la lista de hechizos");
        }

        /// <summary>
        /// Obtiene la descripcion de un hechizo especifico a traves de la API
        /// </summary>
        /// <param name="posicion">La posicion del hechizo en la lista de hechizos</param>
        /// <returns>La descripcion del hechizo seleccionado</returns>
        public async Task<string> ObtenerDescripcionHechizo(int posicion)
        {
            string hechizo = posicion.ToString();
            var direccion = new Uri($"https://hp-api.onrender.com/api/spells?name={hechizo}");

            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                using (var response = await httpClient.GetAsync(""))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var respuesta = await response.Content.ReadAsStringAsync();

                        if (!string.IsNullOrEmpty(respuesta))
                        {
                            var jsonHP = JsonDocument.Parse(respuesta);
                            var descripcion = jsonHP.RootElement[posicion].GetProperty("description").ToString();
                            return descripcion;
                        }
                    }
                }
            }
            throw new Exception($"No se pudo obtener la descripción del hechizo {hechizo}");
        }
    }
}
