using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Vlad", LastName = "Zaharia", id = 0 });
            people.Add(new Person { FirstName = "Alex", LastName = "Zaharia", id = 1 });
            people.Add(new Person { FirstName = "Marius", LastName = "Zaharia", id = 2 });
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }
        [Route("api/People/GetFirstNames")]
        public List<string> GetFirstNames()
        {
            var firstNames = people.Select(firstName => firstName.FirstName).ToList();
            return firstNames;
        }

        // GET: api/People/5
        
        public Person Get(int id)
        {
            var person = people.Where(personId => personId.id == id).FirstOrDefault();
            return person;
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
