using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Models.dbModels
{
    [Table("AUTOR")]
    public partial class Autor
    {
        public Autor()
        {
            Libros = new HashSet<Libro>();
        }

        [Key]
        [Column("ID AUTOR")]
        public int IdAutor { get; set; }
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        [InverseProperty("IdAutorNavigation")]
        public virtual ICollection<Libro> Libros { get; set; }
    }
}
