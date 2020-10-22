using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();                  //grabs all the data from Command
        Command GetCommandById(int id);                         //return data back based on id
    }
}