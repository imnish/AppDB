using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDAL : BaseDAL
    {
        
        #region
        //App Data Operations
        public int AddApp(tbl_App AppDetail)
        {
            context.tbl_App.Add(AppDetail);            
            int count= context.SaveChanges();
            return count;

        }

        public int UpdateApp(tbl_App AppDetail)
        {
            try
            { 
            context.tbl_App.Attach(AppDetail);
            context.Entry(AppDetail).State = System.Data.Entity.EntityState.Modified;
            int count = context.SaveChanges();
            return count;

            }

            catch (Exception ex)
            {
                int count = 0;
                return count;
            }

            
        }

        public int DeleteApp(tbl_App AppDetail)
        {
            //soft delete
            tbl_App App = context.tbl_App.Find(AppDetail.Id);
            App.EndDate = System.DateTime.Now;  
            int count = context.SaveChanges();
            return count;
        }

        public tbl_App GetAppByID(int Id)
        {
            tbl_App App = context.tbl_App.Find(Id);
            return App;
            
        }

        public List<tbl_App> GetAllApps()
        {
            List<tbl_App> applist = new List<tbl_App>();
            applist = context.tbl_App.Where(x => x.EndDate == null).ToList();
            return applist;

        }

              
        #endregion
    }
}
