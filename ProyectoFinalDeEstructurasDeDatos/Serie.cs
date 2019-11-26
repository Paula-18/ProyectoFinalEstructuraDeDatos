using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDeEstructurasDeDatos
{
    class Serie : Contenido
    {

        public Serie() { }
        public Serie(string tipo, string titulo,int temporadas, int año, string genero, string director, string sinopsis, int rating)
        {
            this.Tipo = tipo;
            this.Titulo = titulo;
            this.Temporadas = temporadas;
            this.Año = año;
            this.Genero = genero;
            this.Director = director;
            this.Sinopsis = sinopsis;
            this.Rating = rating;
        }

        public override string ToString()
        {
            return this.Titulo + "(" + this.Año + ")";
        }
    }
}
