using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.CustomModels
{
    public class Occupation
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public IEnumerable<Occupation> GetOccupationList()
        {
            return new List<Occupation>
            {
                new Occupation {Id=1,Name="Doctor" },
                new Occupation {Id=2,Name="Engineer" },
                new Occupation {Id=3,Name="CivilServices" },
                new Occupation {Id=4,Name="Others" }            
            };
        }
    }
}

