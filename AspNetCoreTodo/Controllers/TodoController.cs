using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async IActionResult Index()
        {
            var items  = await _todoItemsService.GetIncompleteItemsAsync();
            
            // Get to-do items from database

            // Put items into a model

            // Pass the view to a model and render
        }
    }
}

