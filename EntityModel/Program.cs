using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterDAL dl = new MasterDAL();
            dl.AddAgency("Starcom");
        }
    }
}
