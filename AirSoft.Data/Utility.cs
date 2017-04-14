using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSoft.Data
{
    public static class Utility
    {
        public static void InitDB()
        {
            var context = new AirSoftContext();
            context.Database.Initialize(true);
        }
    }
}
