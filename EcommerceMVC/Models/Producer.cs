using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string Profile { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
