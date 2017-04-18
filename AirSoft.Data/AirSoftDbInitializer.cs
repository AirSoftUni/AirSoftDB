using AirSoft.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSoft.Data
{
    public class AirSoftDbInitializer : DropCreateDatabaseAlways<AirSoftContext>
    {
        protected override void Seed(AirSoftContext context)
        {
            var ivan = new Player
            {
                FirstName = "Ivan",
                LastName = "Georgiev",
                NickName = "BlackDog"
            };
            var pesho = new Player
            {
                FirstName = "Petar",
                LastName = "Dimitrov",
                NickName = "Cobra"
            };
            var gosho = new Player
            {
                FirstName = "Georgi",
                LastName = "Todorov",
                NickName = "Reaper"
            };

            context.Players.Add(ivan);
            context.Players.Add(pesho);
            context.Players.Add(gosho);

            context.SaveChanges();
        }
    }
}
