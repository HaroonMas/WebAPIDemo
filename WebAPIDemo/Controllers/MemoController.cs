using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class MemoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Memo> Get()
        {
            //return new string[] { "value1", "value2" };
            return new Memo[] { new Memo() { id = "1", Text = "Text1", priority = 1 },
                               new Memo() {id ="2", Text="Text2", priority = 2 }};
        }

        // GET api/<controller>/5
        public Memo Get(int id)
        {
            return new Memo() { id = "1", Text = "Text1", priority = 4 };
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}