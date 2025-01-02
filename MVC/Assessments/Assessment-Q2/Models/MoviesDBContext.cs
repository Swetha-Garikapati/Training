using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assessment_Q2.Models
{
    public class MoviesDBContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

}
