using Delegates.Models;
using Delegates.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> FilterPersons(List<Person> persons, Func<Person, bool> predicate)
        {
            List<Person> filteredPersons = new List<Person>();
            foreach (var person in persons)
            {
                if (predicate(person))
                {
                    filteredPersons.Add(person);
                }
            }
            return filteredPersons;
        }
    }
}
