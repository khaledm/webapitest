using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTestProject.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Products/5
        [Route("{id:int}")]
        public string Get(int id)
        {
            return "value - by INT";
        }

        [Route("{val}")]
        public IEnumerable<string> Get(string val)
        {
            return new [] { "value2 - by STRING VAL" };
        }

        
        [Route("{dob:datetime:regex(\\d{4}-\\d{2}-\\d{2})}")]
        [Route("{*dob:datetime:regex(\\d{4}/\\d{2}/\\d{2})}")] //new
        public IEnumerable<string> Get(DateTime dob)
        {
            return new [] { "value2 - by DATETIME VAL " + dob.ToShortDateString()};
        }

        //[Route("api/Products/{dob:datetime:regex(\\d{4}-\\d{2}-\\d{2})}")]
        //public string Get([FromBody] Product)
        //{
        //    return "value2 - by DATETIME VAL " + dob.ToShortDateString();
        //}

        //// GET: api/Products
        //public void Get([FromBody]string value)
        //{
        //}

     }
}
