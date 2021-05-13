using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName ="Gyan", Lastname = "Prakash", Id = 1, Age=21});
            people.Add(new Person { FirstName = "xyz", Lastname = "abc", Id = 2, Age=22 });
            people.Add(new Person { FirstName = "abc", Lastname = "xyz", Id = 3, Age=19 });

        }
        ///[Route("api/People/GFN/{Id:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstName()
        {
            List<string> output = new List<string>();
            foreach(var item in people)
            {
                output.Add(item.FirstName);
            }
            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {

            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();

        }


        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        //public void Delete(int id)
        //{  }
    }
}
