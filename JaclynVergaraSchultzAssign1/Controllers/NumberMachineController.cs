using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JaclynVergaraSchultzAssign1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Method which has an input {id}, and applies four mathematical operations to it
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// GET api/numbermachine/10 --> responses are: 15, 5, 50, 2
        /// example: 10 + 5 = 15, 10 - 5 = 5, 10 * 5 = 50, 10 / 5 = 2
        /// GET api/numbermachine/-5 --> responses are: 0, -10, -25, -1
        /// example: -5 + 5 = 0, -5 - 5 = -10, -5 * 5 = -25, -5 / 5 = -1
        /// GET api/numbermachine/30 --> responses are: 35, 25, 150, 6
        /// example: 30 + 5 = 35, 30 - 5 = 25, 30 * 5 = 150, 30/5 = 6
        /// </returns>

        // GET api/numbermachine/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 5, id - 5, id * 5, id / 5 };
        }
    }

}

