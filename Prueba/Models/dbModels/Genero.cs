using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Models.dbModels
{
    [Table("GENERO")]
    public partial class Genero
    {
        public Genero()
        {
            Libros = new HashSet<Libro>();
        }

        [Key]
        [Column("ID GENERO")]
        public int IdGenero { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(50)]
        public string Descripcion { get; set; } = null!;

        [InverseProperty("IdGeneroNavigation")]
        public virtual ICollection<Libro> Libros { get; set; }
    }
}
