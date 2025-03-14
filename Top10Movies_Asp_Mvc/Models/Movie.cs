﻿using System.ComponentModel.DataAnnotations;

namespace Top10Movies_Asp_Mvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string? Title { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z][a-z ,.'-]+(?: [A-Z][a-z ,.'-]+)*$",
        ErrorMessage = "Only letters, spaces, and characters (, . ' -) are allowed. Each word must start with an uppercase letter.")]
        public string? Author { get; set; }

        [Required]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Genre must contain only letters.")]
        public string? Genre {  get; set; }
        public int Year { get; set; }
        [Required]
        [RegularExpression(@"^(https?:\/\/.*\.(?:png|jpg|jpeg|gif|bmp|webp))(?:\?.*)?$",
        ErrorMessage = "Please enter a valid image URL ending with .png, .jpg, .jpeg, .gif, .bmp, or .webp.")]
        public string? ImageLink { get; set; }
    }
}
