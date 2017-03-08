using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppRoleDAL : BaseDAL
    {
        #region

        //App Data Operations
        public int AddAppRole(int appid, List<AppRoleModel> AppRoleDetail)
        {
            var count = context.tbl_AppDomain
                        .Where(x => x.AppId == appid).Count();

            if (count > 0)
            {
                count = 0;
                context.tbl_AppRole.RemoveRange(context.tbl_AppRole.Where(x => x.AppId == appid));
                count = context.SaveChanges();
                return count;

            }

            else
            {
                count = 0;

                foreach (AppRoleModel obj in AppRoleDetail)
                {
                    context.tbl_AppRole.Add(new tbl_AppRole { AppId = appid, EmpId = obj.EmpId, AppRoleId=obj.RoleId });
                }
                count = context.SaveChanges();
                return count;

            }

        }

        //public int DeleteAppRole(List<AppRoleModel> AppRoleDetail)
        //{
        //    tbl_AppRole approle = context.tbl_AppRole.Find(AppRoleModel.);
        //    context.tbl_AppAgency.RemoveRange(context.tbl_AppAgency.Where(x => x.AppId == AppRoleDetail.AppId));
        //    int count = context.SaveChanges();
        //    return count;
        //}

        public List<string> GetAllAppByEmpID(int EmpID)
        {
            List<string> appemp = (from c in context.tbl_App
                                   join q in context.tbl_AppRole on c.Id equals q.AppId
                                   where q.EmpId == EmpID
                                   select c.Name.ToString()).ToList();

            //var appagency = from c in context.tbl_App
            //                          join q in context.tbl_AppAgency on c.Id equals q.AppId
            //                          where q.AgencyId == AgencyID
            //                          select c.Name.ToString();

            //List<string> names = appagency.ToList<string>();

            return appemp;
        }

        public List<string> GetAllEmpByAppID(int AppID)
        {

            List<string> appemp = (from c in context.tbl_Employee
                                      join q in context.tbl_AppRole on c.Id equals q.EmpId
                                      where q.AppId == AppID
                                      select c.FirstName.ToString()).ToList();

            return appemp;
            
        }

        //public List<string> GetAllRoleByAppID(int AppID)
        //{

        //    List<string> appagency = (from c in context.tbl_AgencyMaster
        //                              join q in context.tbl_AppAgency on c.Id equals q.AgencyId
        //                              where q.AppId == AppID
        //                              select c.Name.ToString()).ToList();

        //    return appagency;



        //}   







        #endregion
    }
}
