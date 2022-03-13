using EcommerceMVC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Models
{
    public class MovieViewModel
    {

        [Required(ErrorMessage = "Title is Required")]
        [Display(Description = "Movie Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Movie Description is Required")]
        [Display(Description = "Movie Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Display(Description = "Movie Price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Poster is Required")]
        [Display(Description = "Movie Poster")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Start Date is Required")]
        [Display(Description = "Movie Start")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is Required")]
        [Display(Description = "Movie End")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Category is Required")]
        [Display(Description = "Movie Category")]
        public MovieCategory Category { get; set; }

        [Required(ErrorMessage = "Actors is Required")]
        [Display(Description = "Select Actor(s)")]
        public List<int> ActorsId { get; set; }

        [Required(ErrorMessage = "Cinema is Required")]
        [Display(Description = "Movie Cinema")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Producer is Required")]
        [Display(Description = "Movie Producer")]
        public int ProducerId { get; set; }


    }
}
