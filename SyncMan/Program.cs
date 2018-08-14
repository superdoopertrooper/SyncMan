
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncMan
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            OracleDbContext oracleDbContext = new OracleDbContext();
            var subs = oracleDbContext.PTMS_SUBJECTS.ToList();
            log.Info("Hello logging world!");
            Console.ReadLine();
        }
    }
}
