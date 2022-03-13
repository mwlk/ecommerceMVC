using EcommerceMVC.Models;
using System.Collections.Generic;

namespace EcommerceMVC.Data.ViewModels
{
    public class MovieDropdownsViewModel
    {
        public MovieDropdownsViewModel()
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }

        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
