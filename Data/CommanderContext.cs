using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    //inheriting DbContext from EFCore
    public class CommanderContext : DbContext
    {

        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        //representing our Command objects to our database as a DbSet
        //mapping is done here for objects in the Models namespace. more objects there means more mapping to be done here
        public DbSet<Command> Commands { get; set; }
    }
}