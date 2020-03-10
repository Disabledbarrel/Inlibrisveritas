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
        [DisplayName("Rubrik")]
        public string Title { get; set; }
        [DisplayName("Innehåll")]
        public string Content { get; set; }
        [DisplayName("Bild")]
        public string ImageUrl { get; set; }
        [DisplayName("Skapad")]
        public DateTime Created { get; set; }
        [DisplayName("Skriven av")]
        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }

}
}
