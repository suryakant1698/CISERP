using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Models.DBModels
{
    public class MasterTablesOperations
    {
        public IEnumerable<StateMaster> getStates()
        {
            using (CISERPEntities db = new CISERPEntities())
            {
                return db.StateMasters.ToList();
            }
        }
        public IEnumerable<CityMaster> getCitiesByStateId(int id)
        {
            using (CISERPEntities db = new CISERPEntities())
            {
                return db.CityMasters.Where(a => a.Id == id).ToList();
            }
        }
    }
}