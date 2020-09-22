using GigHub2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub2.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
    }
}