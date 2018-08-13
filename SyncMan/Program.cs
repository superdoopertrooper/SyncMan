using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncMan
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleDbContext oracleDbContext = new OracleDbContext();
            var subs = oracleDbContext.PTMS_SUBJECTS.ToList();
            Console.ReadLine();
        }
    }
}
