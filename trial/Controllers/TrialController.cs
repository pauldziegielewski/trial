using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace trial.Controllers
{
    public class TrialController : ApiController
    {



        /// <summary>
        /// This method returns three strings when receieving a post request
        /// <example>POST api/example </example>
        /// Post api/Trial
        /// </summary>
        /// <returns>["Me","YOU", "him"]</returns>
        public IEnumerable<string> Post()
        {
            return new string[] { "Me","YOU", "him" };
        }


        // GET api/Trial{id}
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "he", "him", "her" };
        }

    }
}
