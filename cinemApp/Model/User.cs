﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemApp.Model
{
    class User:Entity 
    {
        public Ticket  Ticket { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int  Age { get; set; }
        public string Password { get; set; }

    }
}
