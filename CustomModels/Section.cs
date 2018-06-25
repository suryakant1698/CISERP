using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.CustomModels
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Section> GetSections()
        {
            return new List<Section> {
                new Section {Id=1,Name="A" },
                new Section {Id=2,Name="B" },
                new Section {Id=3,Name="C" },
                new Section {Id=4,Name="D" }
            };
        }
    }
}