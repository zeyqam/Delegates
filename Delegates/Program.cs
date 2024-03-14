
// delegates-bir methodu bashqa bir methoda parametr olaraq gondermek olur
//void Test()
//{

//}
//void Test2()
//{

//}
using Delegates;
using Delegates.Models;
using Delegates.Services.Interfaces;
using Delegates.Services;

//DelegatePractice delegatePractice = new DelegatePractice();
////delegatePractice.Execute();
////delegatePractice.SumOfNumsByCondition(new List<int> { 1, 2, 3, 4, 5 }, m => m > 3);

//delegatePractice.Execute();
Func<Person, bool> predicate = p => p.Salary > 1000;
IPersonService personService = new PersonService();
List<Person> filteredPersons = personService.FilterPersons(persons, predicate);

Console.WriteLine("Filtered Persons:");
foreach (var person in filteredPersons)
{
    Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Address: {person.Address}");
}





