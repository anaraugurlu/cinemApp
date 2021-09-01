using cinemApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemApp.Repostory
{
   class FakeRepostory
    {
     
        public List<Ticket> GetTicket()
        {
            return new List<Ticket>
            {
                new Ticket
                {
                    Money =6,
                    Number =1
                },
                 new Ticket
                {
                     Money =8,
                    Number =2
                },
                  new Ticket
                {
                      Money =7,
                    Number =3
                },
                   new Ticket
                {
                       Money =5,
                    Number =4
                },
                    new Ticket
                {
                        Money =5,
                    Number =5
                },
            };
        }
        public List <Movie >GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Name="Interstellar"
                },  new Movie
                {
                    Name="Cindrella"
                },  
                new Movie
                {
                    Name="Divergent"
                }, 
                new Movie
                {
                    Name="Insurgent"
                },
                new Movie
                {
                    Name="Kill Bill"
                },
                   new Movie
                {
                },
                    new Movie
                {
                },
                     new Movie
                {
                },                     new Movie
                {
                },                     new Movie
                {
                },                
                new Movie
                {
                },
                  new Movie
                {
                      
                },
                    new Movie
                {
                },
                      new Movie
                {
                },
            };
        
        }
        public List<Admin> GetAllAdmins()
        {
            return new List<Admin>
            {

                    new Admin
                {
                    UserName="admin",
                    Password ="admin",

                },
                       new Admin
                {
                    UserName="admin1",
                    Password ="admin1",

                },   new Admin
                {
                    UserName="admin2",
                    Password ="admin2",

                },   new Admin
                {
                    UserName="admin3",
                    Password ="admin3",

                },
            };
        }
        public List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    UserName="user1",

                   Password ="user1"
                },
                  new User
                {
                    UserName="user",
                    Password ="user"

                },
                new User
                {
                    UserName="user2",
                    Password="user2"

                },
                new User
                {
                    UserName="user3",
                    Password ="user3"

                },
                new User
                {
                    UserName="user4",
                    Password ="user4"

                },
                  new User
                {
                    UserName="user5",
                    Password ="user5"

                },  new User
                {
                    UserName="user6",
                    Password ="user6"

                },

            };
        }
    }
}
