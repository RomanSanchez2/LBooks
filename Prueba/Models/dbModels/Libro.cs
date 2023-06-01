using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Models.dbModels
{
    [Table("LIBRO")]
    public partial class Libro
    {
        public Libro()
        {
            Reseñas = new HashSet<Reseña>();
        }

        [Key]
        [Column("ID LIBRO")]
        public int IdLibro { get; set; }
        [Column("ID GENERO")]
        public int IdGenero { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column("ID AUTOR")]
        public int IdAutor { get; set; }
        [Column("TITULO")]
        public string Titulo { get; set; } = null!;
        [Column("CONTENIDO")]
        public string Contenido { get; set; } = null!;

        [Column("PAGINAS")]
        public int Paginas { get; set; }
        [Column("IMAGEN")]
        [StringLength(50)]
        public string Imagen { get; set; } = null!;

        [ForeignKey("IdAutor")]
        [InverseProperty("Libros")]
        public virtual Autor IdAutorNavigation { get; set; } = null!;
        [ForeignKey("IdGenero")]
        [InverseProperty("Libros")]
        public virtual Genero IdGeneroNavigation { get; set; } = null!;
        [InverseProperty("IdLibroNavigation")]
        public virtual ICollection<Reseña> Reseñas { get; set; }
    }
}
