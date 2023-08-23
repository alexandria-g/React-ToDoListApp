using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using MyBackend.Models;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    private readonly TodoContext _context;

    public TodosController(TodoContext context)
    {
        _context = context;
    }

    // GET: api/Todos
    [HttpGet]
    public ActionResult<IEnumerable<Todo>> GetTodos()
    {
        return _context.Todos.ToList();
    }

    // More methods here for POST, PUT, DELETE...
}
