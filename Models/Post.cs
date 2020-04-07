using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlibrisVeritas.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Required(ErrorMessage = "Fältet måste vara ifyllt")]
        [DisplayName("Rubrik")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Fältet måste vara ifyllt")]
        [DisplayName("Innehåll")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Fältet måste vara ifyllt")]
        [DisplayName("Bild")]
        public string ImageUrl { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Skapad")]
        public DateTime Created { get; set; }

        [DisplayName("Skriven av")]
        public string UserId { get; set; }

        public virtual IdentityUser User { get; set; }

}
}
