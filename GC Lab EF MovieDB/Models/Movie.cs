using System;
using System.Collections.Generic;

namespace GC_Lab_EF_MovieDB.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public double? Runtime { get; set; }


        //public Movie(string title, string genre, float runtime)       adding a constructor here doesn't work in this context
        //{ 
        //    Title = title;
        //    Genre = genre;
        //    Runtime = runtime;
        //}
    }
}
