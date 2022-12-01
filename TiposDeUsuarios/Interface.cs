using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public  interface ITodaLaLista<T>
    {

       List<T> LeerListaCompleta();


    }
}
