using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.CustomModels
{
    public class BloodGroup
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public IEnumerable<BloodGroup> GetAllBloodGroups()
        {
            var list = new List<BloodGroup>
            {
                new BloodGroup {Id=1,Name="O+" },
                new BloodGroup {Id=2,Name="O-" },
                new BloodGroup {Id=3,Name="A-" },
                new BloodGroup {Id=4,Name="A+" },
                new BloodGroup {Id=5,Name="B-" },
                new BloodGroup {Id=6,Name="B+" },
                new BloodGroup {Id=7,Name="AB-" },
                new BloodGroup {Id=8,Name="AB+" }
            };
            return list;
        }
    }
}