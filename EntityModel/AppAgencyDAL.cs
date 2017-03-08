using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess
{
    public class AppAgencyDAL : BaseDAL
    {
        #region
        //App Data Operations
        public int AddAppAgency(int appid, List<tbl_AgencyMaster> AgencyDetail)
        {
            var count = context.tbl_AppAgency
                        .Where(x => x.AppId == appid).Count();

            if (count > 0)
            {
                count = 0;
                context.tbl_AppAgency.RemoveRange(context.tbl_AppAgency.Where(x => x.AppId == appid));
                count = context.SaveChanges();
                return count;

            }

            else
            {
                count = 0;

                foreach (tbl_AgencyMaster obj in AgencyDetail)
                {
                    context.tbl_AppAgency.Add(new tbl_AppAgency { AppId = appid, AgencyId = obj.Id });
                }
                count = context.SaveChanges();
                return count;

            }

        }

        public int DeleteAppAgency(tbl_AppAgency AppAgencyDetail)
        {
            tbl_AppAgency appagency = context.tbl_AppAgency.Find(AppAgencyDetail.AppId);
            context.tbl_AppAgency.RemoveRange(context.tbl_AppAgency.Where(x => x.AppId == AppAgencyDetail.AppId));
            int count = context.SaveChanges();
            return count;
        }

        public List<string> GetAllAppByAgencyID(int AgencyID)
        {
            List<string> appagency = (from c in context.tbl_App
                                      join q in context.tbl_AppAgency on c.Id equals q.AppId
                                      where q.AgencyId == AgencyID
                                      select c.Name.ToString()).ToList();

            //var appagency = from c in context.tbl_App
            //                          join q in context.tbl_AppAgency on c.Id equals q.AppId
            //                          where q.AgencyId == AgencyID
            //                          select c.Name.ToString();

            //List<string> names = appagency.ToList<string>();

            return appagency;
        }

        public List<string> GetAllAgencyByAppID(int AppID)
        {

            List<string> appagency = (from c in context.tbl_AgencyMaster
                                      join q in context.tbl_AppAgency on c.Id equals q.AgencyId
                                      where q.AppId == AppID
                                      select c.Name.ToString()).ToList();
           
            return appagency;
        
        }      


        #endregion
    }
}
