using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public static class Datos
    {
        
        /// <summary>
        /// Se le pasa un string y devuelve el mismo con solo la primer letra en mayuscula
        /// </summary>
        /// <param name="value"> string a modificar</param>
        /// <returns></returns>
        public static string HacerPrimerLetraMayus(this string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

    }
}
