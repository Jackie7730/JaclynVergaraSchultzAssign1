using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JaclynVergaraSchultzAssign1.Controllers
{
    public class HelloWorldController : ApiController
    {
        /// <summary>
        /// Returns the string "Hello World" in a POST request rather than a GET request
        /// </summary>
        /// <returns>
        /// The below message is what I used in the command prompt to send the POST request properly
        /// Microsoft Windows [Version 10.0.22621.2283]
        /// (c) Microsoft Corporation.All rights reserved.
        ///C:\Users\jacly>curl "http://localhost:49273/api/helloworld"
        ///{"Message":"The requested resource does not support http method 'GET'."}
        ///C:\Users\jacly>curl -d "" "http://localhost:49273/api/helloworld"
        ///["Hello World!"]
        ///C:\Users\jacly>
        /// </returns>

        // POST api/values
        public IEnumerable<string> POST()
        {
            return new string[] { "Hello World!" };
        }
    }


}

