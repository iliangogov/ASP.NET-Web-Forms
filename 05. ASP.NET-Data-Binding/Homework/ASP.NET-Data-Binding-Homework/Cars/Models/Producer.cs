using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cars.Models
{
    public class Producer
    {
        public string Name { get; set; }

        public IList<Model> Models { get; set; }
    }
}