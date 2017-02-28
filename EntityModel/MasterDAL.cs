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
    public class MasterDAL
    {
        private readonly AppDb_Entities context;


        public MasterDAL()
        {
            context = new AppDb_Entities();
        }

        public int AddAgency(string agencyname)
        {

            tbl_AgencyMaster agency = new tbl_AgencyMaster();
            agency.Name = agencyname;
            context.tbl_AgencyMaster.Add(agency);
            int count= context.SaveChanges();
            return count;
        }

        public int AddAppRole(string Role)
        {

            tbl_AppRoleMaster role = new tbl_AppRoleMaster();
            role.Name = Role;
            context.tbl_AppRoleMaster.Add(role);
            int count = context.SaveChanges();
            return count;
        }

        public int AddServerType(string type)
        {

            tbl_ServerTypeMaster serverType = new tbl_ServerTypeMaster();
            serverType.Name = type;
            context.tbl_ServerTypeMaster.Add(serverType);
            int count = context.SaveChanges();
            return count;

        }

        public int AddType(string type)
        {

            tbl_ServerTypeMaster serverType = new tbl_ServerTypeMaster();
            serverType.Name = type;
            context.tbl_ServerTypeMaster.Add(serverType);
            int count = context.SaveChanges();
            return count;
        }

        public int AddTechnology(string techname)
        {

            tbl_TechnologyMaster tech = new tbl_TechnologyMaster();
            tech.Name = techname;
            context.tbl_TechnologyMaster.Add(tech);
            int count = context.SaveChanges();
            return count;
        }
    }
}
