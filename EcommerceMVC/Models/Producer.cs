using EcommerceMVC.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Picture is Required")]
        public string Profile { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name > 3 and < 50")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
