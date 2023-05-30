using MessagePack;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Prueba.Models.DTO
{
    public class GeneroDTO
    {

        [Required]
        [Display(Name = "IdGenero")]
        public int IdGenero { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } = null!;

        [JsonIgnore]
        [IgnoreMember]
        [IgnoreDataMember]
        public SelectList? Genero {get; set; }

    }
}
