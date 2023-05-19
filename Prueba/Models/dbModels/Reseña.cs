using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Models.dbModels
{
    [Table("RESEÑAS")]
    public partial class Reseña
    {
        [Key]
        [Column("ID RESEÑAS")]
        public int IdReseñas { get; set; }
        [Column("ID USUARIO")]
        public int IdUsuario { get; set; }
        [Column("TITULO")]
        [StringLength(50)]
        public string Titulo { get; set; } = null!;
        [Column("FECHA", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column("ID  LIBRO")]
        public int IdLibro { get; set; }

        [ForeignKey("IdLibro")]
        [InverseProperty("Reseñas")]
        public virtual Libro IdLibroNavigation { get; set; } = null!;
        [ForeignKey("IdUsuario")]
        [InverseProperty("Reseñas")]
        public virtual ApplicationUser IdUsuarioNavigation { get; set; } = null!;
    }
}
