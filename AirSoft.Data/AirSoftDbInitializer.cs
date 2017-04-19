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
            var drago = new Player
            {
                FirstName = "Dragomir",
                LastName = "Petkov",
                NickName = "Terror"
            };
            var dobri = new Player
            {
                FirstName = "Dobroslav",
                LastName = "Stoqnov",
                NickName = "Stallker"
            };

            context.Players.Add(ivan);
            context.Players.Add(pesho);
            context.Players.Add(gosho);

            context.SaveChanges();

            var ghosts = new Team
            {
                Name = "Ghosts"
            };
            ghosts.Players.Add(pesho);
            ghosts.Players.Add(gosho);

            var assasins = new Team
            {
                Name = "Assasins"
            };
            assasins.Players.Add(dobri);
            assasins.Players.Add(drago);

            context.Teams.Add(ghosts);
            context.Teams.Add(assasins);
            context.SaveChanges();

            var slivnitsa = new Game
            {
                Name = "Capture the flag",
                CreatorsTeam = ghosts,
                StartDate = new DateTime(2017, 05, 05),
                Description = "Must capture more flags.",
                Adress = "Slivnitsa"
            };
            slivnitsa.ParticipatingPlayers.Add(pesho);
            slivnitsa.ParticipatingPlayers.Add(gosho);
            slivnitsa.ParticipatingPlayers.Add(dobri);

            var bosnec = new Game
            {
                Name = "Team Defense",
                CreatorsTeam = assasins,
                StartDate = new DateTime(2017, 07, 05),
                Description = "Defend your base camp.",
                Adress = "Bosnec"
            };
            bosnec.ParticipatingPlayers.Add(gosho);
            bosnec.ParticipatingPlayers.Add(dobri);
            bosnec.ParticipatingPlayers.Add(ivan);
            bosnec.ParticipatingPlayers.Add(drago);

            context.Games.Add(slivnitsa);
            context.Games.Add(bosnec);
            context.SaveChanges();
        }
    }
}
