﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Clase_Serializadora <T>
    {

        static string ruta;


        static Clase_Serializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\ArruaMatias_Archivos";
        }

        /// <summary>
        /// Exporta en formato json
        /// </summary>
        /// <param name="datos"> De tipo generico, que se quiere exportar</param>
        /// <param name="nombreArchivo"> Nombre que se quiere dar al archivo</param>
        /// <exception cref="Exception"></exception>
        public static void EscribirJson(T datos, string nombreArchivo)
        {
            string rutaCompleta = ruta + @"\_" + nombreArchivo + ".json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string objetoJson = JsonSerializer.Serialize(datos);
                File.WriteAllText(rutaCompleta, objetoJson);

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo{rutaCompleta}");
            }
        }

        /// <summary>
        /// Exportar en formato csv
        /// </summary>
        /// <param name="datos">De tipo generico, que se quiere exportar</param>
        /// <param name="nombreArchivo">Nombre que se quiere dar al archivo</param>
        /// <exception cref="Exception"></exception>
        public static void EscribirCsv(T datos,string nombreArchivo)
        {           
           string rutaCompleta = ruta + @"\_" + nombreArchivo + ".csv";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }                  
                File.WriteAllText(rutaCompleta, datos.ToString());

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo{rutaCompleta}");
            }
        }
    }
}
