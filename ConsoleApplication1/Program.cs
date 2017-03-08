using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MasterDO dl = new MasterDO();
            //dl.DeleteAgency(1);
            //tbl_App app = new tbl_App();
            //AppDAL dl = new AppDAL();
         

            //app.Name = "Onyx Media App1";
            //app.PID = 143634;
            //dl.AddApp(app);
            //dl.GetAppByID(3);
            //dl.GetAllApps();
            //dl.GetAllApps();
            //tbl_AppAgency appagency = new tbl_AppAgency();
            //AppAgencyDAL dl = new AppAgencyDAL();
            //List<tbl_AppAgency> agency = new List<tbl_AppAgency>();
            
            //agency.Add( new tbl_AppAgency{AppId = 1, AgencyId = 1});
            //agency.Add( new tbl_AppAgency{AppId = 1, AgencyId = 2});
            //dl.AddAppAgency(agency);

            //tbl_AppAgency appagency = new tbl_AppAgency();
            AppAgencyDAL dl = new AppAgencyDAL();
            //appagency.AppId = 1;

            //int AppId = 1;
            //List<tbl_AgencyMaster> agencyMast = new List<tbl_AgencyMaster>();
            //agencyMast.Add(new tbl_AgencyMaster{Id=1, Name="Starcom"});
            //agencyMast.Add(new tbl_AgencyMaster { Id = 2, Name = "Mediavest" });
            //dl.AddAppAgency(AppId, agencyMast);
            //dl.DeleteAppAgency(appagency);
            int AgencyId = 1;
            dl.GetAllAppByAgencyID(AgencyId);

          
      

        
                      
        }
    }
}
