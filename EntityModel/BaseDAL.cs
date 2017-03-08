using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaseDAL
    {
        public readonly AppDb_Entities context;
        
        //DB Context Initialising
        public BaseDAL()
        {
            context = new AppDb_Entities();
        }
    }
}
