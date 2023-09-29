using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JaclynVergaraSchultzAssign1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the string "Greetings to {id} people!" where id is an integer value
        /// </summary>
        /// <returns>
        /// GET api/greeting/3 --> Response is "Greetings to 3 people!"
        /// GET api/greeting/6 --> Response is "Greetings to 6 people!"
        /// GET api/greeting/0 --> Response is "Greetings to 0 people!"
        /// </returns>

        // GET api/greeting/{id}
        public IEnumerable<string> Get()
        {
            return new string[] { "Greetings to 3 people!", "Greetings to 6 people!", "Greetings to 0 people!" };
        }

    }
}
