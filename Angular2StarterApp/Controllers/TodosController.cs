using Angular2StarterApp.Core;
using Angular2StarterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular2StarterApp.Controllers
{
    public class TodosController : ApiController
    {
        static TodoContext _context = new TodoContext();

        public IHttpActionResult Get()
        {
            return Ok(_context.GetTodos());
        }

        public IHttpActionResult Post(Todo todo)
        {
            return Ok(_context.AddTodo(todo));
        }

        public IHttpActionResult Put(Todo todo)
        {
            return Ok(_context.UpdateTodo(todo));
        }
    }
}
