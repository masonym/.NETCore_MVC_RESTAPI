using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{

    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="cooom", Line="yessssssir", Platform="the interwebs"},
                new Command{Id=1, HowTo="cringe", Line="foo", Platform="the windows"},
                new Command{Id=2, HowTo="bar", Line="wooyeah", Platform="the door"}
            };

            return commands;
        }



        public Command GetCommandById(int id)
        {
            return new Command { Id = id, HowTo = "cooom", Line = "yessssssir", Platform = "the interwebs" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
