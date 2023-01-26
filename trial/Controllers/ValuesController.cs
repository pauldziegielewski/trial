using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace trial.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "pull up in a monsta", "automobile gangsta", "with a bad bitch that came from Sri Lanka" };
        }

        // GET api/values/5
        // input: integer
        // output: the next four integers after the input
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id+21,id+22, id+23, id+24};
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
