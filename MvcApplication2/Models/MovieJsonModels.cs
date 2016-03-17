using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    
    public class moviesManagerVM
    {
        public List<movieVm> movies { get; set; }
        
    }
    
    public class movieVm
    {
        public string movieID { get; set; }
        public string movieTitle { get; set; }
        public string releaseDate { get; set; }
        public string quantity { get; set; }
        
    }
    
}