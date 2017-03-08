using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDomainDAL : BaseDAL 
    {

        #region
        //App Data Operations
        public int AddAppDomain(int appid, List<tbl_DomainMaster> DomainDetail)
        {
            var count = context.tbl_AppDomain
                        .Where(x => x.AppId == appid).Count();

            if (count > 0)
            {
                count = 0;
                context.tbl_AppDomain.RemoveRange(context.tbl_AppDomain.Where(x => x.AppId == appid));
                count = context.SaveChanges();
                return count;

            }

            else
            {
                count = 0;

                foreach (tbl_DomainMaster obj in DomainDetail)
                {
                    context.tbl_AppDomain.Add(new tbl_AppDomain{ AppId = appid, DomainId = obj.Id });
                }
                count = context.SaveChanges();
                return count;

            }

        }

        public int DeleteAppDomain(tbl_AppDomain AppDomainDetail)
        {
            tbl_AppDomain appdomain = context.tbl_AppDomain.Find(AppDomainDetail.AppId);
            context.tbl_AppDomain.RemoveRange(context.tbl_AppDomain.Where(x => x.AppId == AppDomainDetail.AppId));
            int count = context.SaveChanges();
            return count;
        }

        public List<string> GetAllAppByDomainID(int DomainID)
        {
            List<string> appdomain = (from c in context.tbl_App
                                      join q in context.tbl_AppDomain on c.Id equals q.AppId
                                      where q.DomainId == DomainID
                                      select c.Name.ToString()).ToList();

            //var appagency = from c in context.tbl_App
            //                          join q in context.tbl_AppAgency on c.Id equals q.AppId
            //                          where q.AgencyId == AgencyID
            //                          select c.Name.ToString();

            //List<string> names = appagency.ToList<string>();

            return appdomain;
        }

        public List<string> GetAllDomainByAppID(int AppID)
        {

            List<string> appdomain = (from c in context.tbl_DomainMaster
                                      join q in context.tbl_AppDomain on c.Id equals q.DomainId
                                      where q.AppId == AppID
                                      select c.Name.ToString()).ToList();

            return appdomain;

        }


        #endregion







    }
}
