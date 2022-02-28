using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Picture")]
        public string Profile { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
