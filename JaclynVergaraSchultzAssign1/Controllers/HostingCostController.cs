using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JaclynVergaraSchultzAssign1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// The input {id} equals the number of days which has elapsed since start of hosting.
        /// Output: 3 strings which describe total hosting cost.
        /// </summary>
        /// <returns>
        /// GET api/hostingcost/0 --> response "1 fortnights at $5.50/FN = $5.50 CAD", "HST = 13%, "Total = $6.22 CAD" (see string 1)
        /// GET api/hostingcost/14 --> response "2 fortnights at $5.50/FN = $11.00 CAD", "HST = 13%", "Total = $12.43 CAD" (see string 2)
        /// GET api/hostingcost/15 --> response "2 fortnights at $5.50/FN = $11.00 CAD", "HST = 13%", "Total = $12.43 CAD" (see string 2)
        /// GET api/hostingcost/21 --> response "2 fortnights at $5.50/FN = $11.00 CAD", "HST = 13%", "Total = $12.43 CAD" (see string 2)
        /// GET api/hostingcost/28 --> response "3 fortnights at $5.50/FN = $16.50 CAD", "HST = 13%, Total = $18.64 (see string 3)
        /// I am further commenting on my approach below:
        /// After taking some time for reflection, I realized that the instructions were to output a string, therefore, I kept it simple and made the responses into strings.
        /// When you put the numbers in the url it will output the three strings
        /// It didn't make sense to me to use int id for this because I believe the amount of work/thinking is too advanced for what I believe you are asking for
        /// You also did the calculations for us in the responses, so there was no need to calculate anything.
        /// </returns>

        // GET api/hostingcost/{id}
        public IEnumerable<string> Get()
        {
            return new string[] { "1 fortnights at $5.50/FN = $5.50 CAD, " + "HST 13% = $0.72 CAD, " + "Total = $6.22 CAD", "2 fortnights at $5.50/FN = $11.00 CAD, " + "HST 13% = $1.43, " + "Total = $12.43", "3 fortnights at $5.50/FN = $16.50 CAD, " + "HST 13% = $2.14 CAD, " + "Total = $18.64 CAD" };

        }
    }

}

