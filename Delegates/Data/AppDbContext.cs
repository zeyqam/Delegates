using Delegates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Data
{
    public class AppDbContext
    {
        public static List<Person> persons;
       static AppDbContext()
        {
            persons = new List<Person>
            {
                new Person()
                {

                    FirstName="Fexriyye",
                    LastName="Tagizade",
                    Address="28 may",
                    Salary=1200

                },
                new Person()
                {
                    
                    FirstName="Elmir ",
                    LastName="Qafarzade",
                    Address="Sahil",
                    Salary=600

                },
                new Person()
                {
                    
                    FirstName="Sirac",
                    LastName="Memmedov",
                    Address="Masazir",
                    Salary=2300
                },
                new Person()
                {
                    
                    FirstName="Reshad",
                    LastName="Agayev",
                    Address="Neftciler",
                    Salary=500
                },
                new Person()
                {
                    
                    FirstName="Behruz",
                    LastName="Eliyev",
                    Address="Kurdexani",
                    Salary=3300
                }

            };
        }
    }
}
