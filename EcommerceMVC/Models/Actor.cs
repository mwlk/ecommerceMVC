using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture Is Required")]
        public string Profile { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name > 3 and < 50")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography Is Required")]
        public string Bio { get; set; }

        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
