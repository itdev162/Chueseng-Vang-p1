using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Controllers                   
{
    [Route("api/commands")]                                             //API Endpoint Route. 
    [ApiController]
    public class CommandsController : ControllerBase                    //inherits from ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)            //for dependency injected to the interface
        {
            _repository = repository;                                   //what was injected is saved to _repository
        }

        [HttpGet]                                                       //GET api/commands. endpoint one
        public ActionResult <IEnumerable<Command>> GetAllCommands()     //returns all data from Command
        {
            var commandItems = _repository.GetAppCommands();            //commandItems holds all the data

            return Ok(commandItems);                                    //returns all commands with 200 success
        }

        [HttpGet("{id}")]                                               //GET api/commands/1    endpoint two
        public ActionResult <Command> GetCommandById(int id)            //returns a single data from Command
        {
            var commandItems = _repository.GetCommandById(id);          //commandItems hold the first command
            return Ok(commandItems);                                    //returns the command with 200 success
        }
    }
}