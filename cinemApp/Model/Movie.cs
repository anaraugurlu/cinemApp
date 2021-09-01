using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemApp.Model
{
    class Movie:Entity 
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
      
        public string Description { get; set; }
        public dynamic Data { get; set; }
        public dynamic SingleData { get; set; }

    }
}
