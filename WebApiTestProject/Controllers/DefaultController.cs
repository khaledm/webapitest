using WebApiTestProject.Controllers;
namespace RoyalLondon.Soa.EstablishNeedsService.Controllers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using WebApiTestProject.Models;
    using System.Runtime.Serialization;

    /// <summary>
    /// The products controller.
    /// </summary>
   [RoutePrefix("api/details")]
    public class DetailsController : ApiController
    {
        private readonly IEnumerable<ProductPlan> availableProducts = new List<ProductPlan>(7)
        {
            new OverFifty { Name = "Over 50's" },            
            new LifeCover { Name = "Life Cover - LTA" },
            new LifeCover { Name = "Life Cover - DTA" },
            new LifeCover { Name = "Life Cover - FIB" },
            new Funeral { Name = "Funeral" },
            new WpSavings { Name = "WP Savings" },
            new WpBonds { Name = "WP Bond" }
        };

        /// <summary> The get. </summary>
        /// <returns> The <see cref="IEnumerable"/>. </returns>         
        public IEnumerable<ProductPlan> Get()
        {
            return availableProducts.ToArray();
        }

        [Route("{val}")]
        public IEnumerable<ProductPlan> Get(string val)
        {
            return availableProducts.Take(1);
        }

        [Route("{dob:datetime:regex(\\d{4}-\\d{2}-\\d{2})}")]
        [Route("{*dob:datetime:regex(\\d{4}/\\d{2}/\\d{2})}")] //new
        public IEnumerable<ProductPlan> Get(DateTime dob)
        {
            return availableProducts.Take(3).ToArray();
        }
    }
}
