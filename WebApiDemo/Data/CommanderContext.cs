using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class CommanderContext:DbContext
    {
        //We are calling to object of Dbcontext
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }
        public DbSet<Command> Commands { get; set; }
    }
}
