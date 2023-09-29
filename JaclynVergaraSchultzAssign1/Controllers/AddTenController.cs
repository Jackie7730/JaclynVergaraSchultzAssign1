using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JaclynVergaraSchultzAssign1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns 10 more than the integer input {id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// GET api/addten/21 --> response = 31
        /// example: 21 + 10 = 31
        /// GET api/adten/0 --> response = 10
        /// example: 0 + 10 = 10
        /// GET api/addten/-9 --> response = 1
        /// example: -9 + 10 = 1
        /// I also thought of doing the returns together i.e. {21 + 10, 0 + 10, -9 + 10} to have the 3 inputs appear at the same time.
        /// </returns>

        // GET api/addten/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 10 };
        }

    }
}
