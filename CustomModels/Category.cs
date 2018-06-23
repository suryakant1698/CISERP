using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.CustomModels
{
    public class Category
    {
        public int  Id { get; set; }
        public string   Name{ get; set; }
        public IEnumerable<Category> GetAllcagteories()
        {
           return new List<Category> {
                new Category {Id=1,Name="Genral" },
                new Category {Id=2,Name="OBC" },
                new Category {Id=3,Name="SC/St" },
                new Category {Id=4,Name="Others" }
            };
           
            
        }
    }
}