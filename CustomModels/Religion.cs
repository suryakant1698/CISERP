using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.CustomModels
{
    public class Religion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Religion> GetAllReligions()
        {
            var list = new List<Religion>{
                new Religion{Id=1,Name="Hindu", },
                new Religion {Id=2,Name="Muslim" },
                new Religion {Id=3,Name="Sikh" },
                new Religion {Id=4,Name="Christian" },
                new Religion {Id=5,Name="Others" }

            };
            return list;
        }
    }
}