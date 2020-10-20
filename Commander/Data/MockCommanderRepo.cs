using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>        //Command datas 
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water, place egg in water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut Bread", Line="Get a knife", Platform="Knife and Chopping board"},
                new Command{Id=2, HowTo="Make a cup of tea", Line="Boil water, hot water to cup, place teabag in cup,", Platform="Kettle & Cup"},
            };

            return commands;
        } 
 
        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water, place egg in water", Platform="Kettle & Pan"};
        }
    }
}