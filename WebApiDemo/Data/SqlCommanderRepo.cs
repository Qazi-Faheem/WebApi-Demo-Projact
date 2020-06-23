using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class SqlCommanderRepo : IWebApiDemoRepo
    {

        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            // throw new NotImplementedException();
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            // throw new NotImplementedException();
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            //  throw new NotImplementedException();
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            //throw new NotImplementedException();
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            //throw new NotImplementedException();
           return  (_context.SaveChanges()>0);
        }

        public void UpdateCommand(Command cmd)
        {
            // throw new NotImplementedException();
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Update(cmd);
        }
    }
}
