using Angular2StarterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular2StarterApp.Core
{
    public class TodoContext
    {
        static List<Todo> todos = new List<Todo>();

        public TodoContext()
        {
            todos.Add(new Todo
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Kill All Humans!",
                Notes = "Would like to wrap this up before tea time."
            });
            todos.Add(new Todo
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Clean the gutters.",
                Notes = "Need to clean out all the human remains. Pretty sure there is a foot in the drainage pipe."
            });
        }

        public List<Todo> GetTodos()
        {
            return todos;
        }

        public Todo AddTodo(Todo todo)
        {
            todo.ID = Guid.NewGuid().ToString();
            todos.Add(todo);

            return todos.Find(i => i.ID == todo.ID);
        }

        public Todo UpdateTodo(Todo todo)
        {
            var index = todos.IndexOf(todos.Find(i => i.ID == todo.ID));
            todos.RemoveAt(index);
            todos.Insert(index, todo);

            return todos.Find(i => i.ID == todo.ID);
        }
    }
}
