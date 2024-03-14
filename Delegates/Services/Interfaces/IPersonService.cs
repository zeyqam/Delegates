using Delegates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Services.Interfaces
{
    public interface IPersonService
    {
        List<Person> FilterPersons(List<Person> persons, Func<Person, bool> predicate);
    }
}
