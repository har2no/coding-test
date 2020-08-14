using System.Collections.Generic;
using Suhartono_Backend.Data;
using Suhartono_Backend.Models;
using Microsoft.AspNetCore.Mvc;


namespace Suhartono_Backend.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockSuhartono_backendRepo _repository = new MockSuhartono_backendRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<TodoItem>> GetAllCommands()
        {
            var commandItems = _repository.AppCommands;

            return Ok(commandItems);
        }
        //GET api/commands/{id}
        [HttpGet("{Id}")]
        public ActionResult <TodoItem> GetCommandById(int Id)
        {
            var commandItem = _repository.GetCommandById(Id);
            return Ok(commandItem);
        }
    }
}