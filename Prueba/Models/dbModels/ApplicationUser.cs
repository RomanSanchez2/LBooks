using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Prueba.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser()
        {
            Reseñas = new HashSet<Reseña>();
        }


        public virtual ICollection<Reseña> Reseñas { get; set; }
    }
}
