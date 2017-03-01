using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using DataAccess.Model;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace DataAccess
{
    public class MasterDO
    {
        private readonly AppDb_Entities context;
        
        //DB Context Initialising
        public MasterDO()
        {
            context = new AppDb_Entities();
        }

        #region
        //Agency Master Data Operations
        public int AddAgency(string agencyname)
        {

            tbl_AgencyMaster agency = new tbl_AgencyMaster();
            agency.Name = agencyname;
            context.tbl_AgencyMaster.Add(agency);
            int count= context.SaveChanges();
            return count;
        }

        public int UpdateAgency(int id, string agencyname)
        {
            tbl_AgencyMaster agency= context.tbl_AgencyMaster.Find(id);
            agency.Name = agencyname;
            int count = context.SaveChanges();
            return count;
        }

        public int DeleteAgency(int id)
        {
            tbl_AgencyMaster agency = context.tbl_AgencyMaster.Find(id);
            agency.EndDate = System.DateTime.Now;
            int count = context.SaveChanges();
            return count;
        }
        #endregion

        #region
        //App Role Master Data Operations
        public int AddAppRole(string Role)
        {

            tbl_AppRoleMaster role = new tbl_AppRoleMaster();
            role.Name = Role;
            context.tbl_AppRoleMaster.Add(role);
            int count = context.SaveChanges();
            return count;
        }

        public int UpdateRole(int id, string Role)
        {
            tbl_AppRoleMaster role = context.tbl_AppRoleMaster.Find(id);
            role.Name = Role;
            int count = context.SaveChanges();
            return count;
        }

        public int DeleteRole(int id)
        {
            tbl_AppRoleMaster role = context.tbl_AppRoleMaster.Find(id);
            role.EndDate = System.DateTime.Now;
            int count = context.SaveChanges();
            return count;
        }
        #endregion

        #region
        //Server Type Master Data Operations
        public int AddServerType(string type)
        {

            tbl_ServerTypeMaster serverType = new tbl_ServerTypeMaster();
            serverType.Name = type;
            context.tbl_ServerTypeMaster.Add(serverType);
            int count = context.SaveChanges();
            return count;
        }

        public int UpdateServerType(int id, string type)
        {
            tbl_ServerTypeMaster serverType = context.tbl_ServerTypeMaster.Find(id);
            serverType.Name = type;
            int count = context.SaveChanges();
            return count;
        }

        public int DeleteServerType(int id)
        {
            tbl_ServerTypeMaster serverType = context.tbl_ServerTypeMaster.Find(id);
            serverType.EndDate = System.DateTime.Now;
            int count = context.SaveChanges();
            return count;
        }
        #endregion

        #region
        //Technology Master Data Operations
        public int AddTechnology(string techname)
        {

            tbl_TechnologyMaster tech = new tbl_TechnologyMaster();
            tech.Name = techname;
            context.tbl_TechnologyMaster.Add(tech);
            int count = context.SaveChanges();
            return count;
        }

        public int UpdateTechnology(int id, string techname)
        {
            tbl_TechnologyMaster tech = context.tbl_TechnologyMaster.Find(id);
            tech.Name = techname;
            int count = context.SaveChanges();
            return count;
        }

        public int DeleteTechnology(int id)
        {
            tbl_TechnologyMaster tech = context.tbl_TechnologyMaster.Find(id);
            tech.EndDate = System.DateTime.Now;
            int count = context.SaveChanges();
            return count;
        }
        #endregion
    }
}
