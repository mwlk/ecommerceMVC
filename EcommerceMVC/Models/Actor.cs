using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string Profile { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
