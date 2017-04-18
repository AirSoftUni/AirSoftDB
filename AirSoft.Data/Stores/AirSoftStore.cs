using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSoft.Data.Stores
{
    public class AirSoftStore
    {
        private AirSoftContext context = new AirSoftContext();

        public void Initialize()
        {
            context.Database.Initialize(true);
        }
    }
}
