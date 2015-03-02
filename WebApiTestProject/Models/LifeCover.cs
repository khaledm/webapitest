using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebApiTestProject.Models
{
    public class LifeCover : ProductPlan
    {
        public bool IsInRange() {
            return true;
        }
    }
}
