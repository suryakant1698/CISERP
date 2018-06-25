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
                return  db.CityMasters.Where(a => a.StateId == id).ToList();                
            }
        }
        public IEnumerable<CountryMaster> GetCountries()
        {
            using (CISERPEntities db = new CISERPEntities())
            {
                return db.CountryMasters.ToList();
            }
        }
        public IEnumerable<StateMaster> getStates(int id)
        {
            using (CISERPEntities db = new CISERPEntities())
            {
                return db.StateMasters.Where(a=>a.CountryId==id).ToList();
            }
        }
        public IEnumerable<ClassMaster> GetClasses()
        {
            using (CISERPEntities db = new CISERPEntities())
            {
                return db.ClassMasters.ToList();
            }
        }
        public IEnumerable<BoardMaster> GetBoards()
        {
            using (CISERPEntities dn = new CISERPEntities())
            {
                return dn.BoardMasters.ToList();
            }
        }
    }
}