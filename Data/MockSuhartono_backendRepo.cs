using System.Collections.Generic;
using Suhartono_Backend.Models;

namespace Suhartono_Backend.Data
{
    public class MockSuhartono_backendRepo : ISuhartono_backendRepo
    {
        public IEnumerable<TodoItem> AppCommands
        {
            get
            {
                var commands = new List<TodoItem>
            {
                new TodoItem{Id=0, DateExp="12/05/2020", Title="Egg", Description="Chic Farm", PercentComplete=10.00},
                new TodoItem{Id=1, DateExp="12/15/2020", Title="Bread", Description="Factory bread", PercentComplete=7.00},
                new TodoItem{Id=2, DateExp="12/20/2020", Title="Coffee", Description="Kettle & Pan", PercentComplete=19.00},
                new TodoItem{Id=3, DateExp="12/25/2020", Title="Tea", Description="Tea bag", PercentComplete=60.00}
            };
                return commands;
            }
        }

        public TodoItem GetCommandById(int Id)
        {
            return new TodoItem{Id=0, DateExp="12/05/2020", Title="Egg", Description="Chic Farm", PercentComplete=10.00};
        }
    }
}