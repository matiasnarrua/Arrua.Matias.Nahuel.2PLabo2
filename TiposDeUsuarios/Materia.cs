using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Materia
    {
        private string _nombre = "";       
        private string _profesor = "";
        private string _materiaCorrelativa = "";


       
        public Materia()
        {

        }
        public Materia(string nombre):this()
        {
            this.Nombre = nombre;
        }
        public Materia(string nombre,string correlativa) : this(nombre)
        {
            this.MateriaCorrelativa = correlativa;
        }
        public Materia(string nombre, string profesor,string correlativa):this(nombre,correlativa)
        {                    
            this.Profesor = profesor;
            
        }

        public string Nombre { get => _nombre; set => _nombre = value; }             
        public string Profesor { get => _profesor; set => _profesor = value; }
       
        public string MateriaCorrelativa { get => _materiaCorrelativa; set => _materiaCorrelativa = value; }

        /// <summary>
        /// instancia y agrega nueva materia a la lista estatica de listaMaterias
        /// 
        /// </summary>
        /// <param name="nombre">nombre de la materia</param>        
        /// <param name="correlativa">nombre de la materia correlativa</param>
        public virtual void CargarMateria(string nombre, string correlativa)
        {
            Datos.listaMaterias.Add(new Materia(Datos.HacerPrimerLetraMayus(nombre), Datos.HacerPrimerLetraMayus(correlativa)));
        }
        


    }
}


