using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace Prueba.Models
{
    public class LibroHR
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public int IdGenero { get; set; }
        public DateTime Fecha { get; set; }
        public int IdAutor { get; set; }

        public int Paginas { get; set; }

        public string Imagen { get; set; } = null!;
    }
}
