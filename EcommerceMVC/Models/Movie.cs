using EcommerceMVC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "Image")]
        public string ImageURL { get; set; }
        [Display(Name = "Start")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End")]
        public DateTime EndDate { get; set; }
        //[Display(Name = "Category")]
        public MovieCategory Category { get; set; }

        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }


        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
