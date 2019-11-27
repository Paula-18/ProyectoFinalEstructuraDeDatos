using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDeEstructurasDeDatos
{
    class Contenido
    {
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        public int Temporadas { get; set; }
        public int Año { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }
        public string Sinopsis { get; set; }
        public int Rating { get; set; }

        /*public Contenido(string tipo, string titulo, int temporadas, int año, string genero, string director, string sinopsis, int rating)
        {
            this.Titulo = tipo;
            this.Titulo = titulo;
            this.Temporadas = temporadas;
            this.Año = año;
            this.Genero = genero;
            this.Director = director;
            this.Sinopsis = sinopsis;
            this.Rating = rating;
        }*/
    }
}
