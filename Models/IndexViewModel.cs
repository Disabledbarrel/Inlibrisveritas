using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlibrisVeritas.Models
{
    public class IndexViewModel
    {
        // Properties
        [Required(ErrorMessage = "Fältet måste vara ifyllt")]
        [MinLength(3, ErrorMessage = "Namn måste vara minst 3 bokstäver")]
        [DisplayName("Namn")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fältet måste vara ifyllt")]
        [EmailAddress(ErrorMessage = "Felaktig e-postadress")]
        [DisplayName("E-post")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Fältet måste vara ifyllt")]
        [MinLength(5, ErrorMessage = "Rubrik måste vara minst 5 bokstäver")]
        [DisplayName("Rubrik")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Fältet måste vara ifyllt")]
        [MaxLength(500, ErrorMessage = "Max 500 tecken får anges")]
        [DisplayName("Meddelande")]
        public string Message { get; set; }
    }
}
