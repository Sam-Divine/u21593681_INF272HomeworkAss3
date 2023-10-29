using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21593681_INF272HomeworkAss3.Models
{
    public class LibraryViewModel
    {
        public authors authors { get; set; }
        public books books { get; set; }
        public borrows borrows { get; set; }
        public students students { get; set; }
        public types types { get; set; }


    }
}