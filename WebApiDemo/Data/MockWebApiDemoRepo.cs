using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class MockWebApiDemoRepo : IWebApiDemoRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            // throw new NotImplementedException();
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Qazi", Line="Qazi@gmail.com",Platform="It" },
                new Command{Id=1, HowTo="Faheem", Line="Faheem@gmail.com",Platform="Cs" },
                new Command{Id=2, HowTo="Afridi", Line="afridi@gmail.com",Platform="Se" }



            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            // throw new NotImplementedException();
            return new Command { Id = 0, HowTo = "Qazi", Line = "Qazi@gmail.com", Platform = "It" }; 
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
