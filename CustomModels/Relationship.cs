using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.CustomModels
{
    public class Relationship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Relationship> GetRelationshipList()
        {
            return new List<Relationship>
           {
               new Relationship {Id=1,Name="Father" },
               new Relationship {Id=2,Name="Mother" },
               new Relationship {Id=3,Name="Brother" },
               new Relationship {Id=4,Name="Sister" },
               new Relationship {Id=5,Name="Uncle" },
               new Relationship {Id=6,Name="Aunt" },
               new Relationship {Id=7,Name="In Laws" },
               new Relationship {Id=8,Name="Others" }
           };
        }
    }
}