using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BestMoviesEver.Models
{
    public class Movies
    {
        [Key]
        public int MovieID { get; set; }

        public string MovieTitle { get; set; }
        public string MovieDescription { get; set; }

        public int MovieRating { get; set; }
    }
}