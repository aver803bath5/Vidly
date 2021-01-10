using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MovieFormVIewModel
    {
        public Movie Movie  { get; set; }
        public List<Genre> Genres { get; set; }
    }
}