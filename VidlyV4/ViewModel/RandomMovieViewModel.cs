using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyV4.Models;

namespace VidlyV4.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}