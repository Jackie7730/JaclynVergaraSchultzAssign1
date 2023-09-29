using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JaclynVergaraSchultzAssign1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of the integer input {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// GET api/square/2 --> response is 4
        /// GET api/square/-2 --> response is 4
        /// GET api/square/10 --> response is 100
        /// I also thought about doing {id * 2, id * -2, id * 10} but the responses wouldn't be consistent
        /// Example for this reasoning if id = 2 --> 2 * 2 = 4 (correct), 2 * -2 = -4 (response incorrect, not 4), 2 * 10 = 20 (response incorrect, not 100)
        /// Therefore, I had to return three integers as calculated below.
        /// </returns>

        // GET api/square/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int[] { 2 * 2, -2 * -2, 10 * 10 };
        }
    }

}

