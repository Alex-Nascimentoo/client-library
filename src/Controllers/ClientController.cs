using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using fullstack.src.Models;
using fullstack.src.Persistence;
using Microsoft.EntityFrameworkCore;

namespace fullstack.src.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private Context _context { get; set; }

    public ClientController(Context context)
    {
        _context = context;
    }

    [HttpGet]
    public List<Client> Get()
    {
        Response.Headers.Add("Access-Control-Allow-Origin", "*");
        return _context.Clients.Include(c => c.Contracts).ToList();
    }

    [HttpPost]
    public Client Post([FromBody]Client newClient)
    {
        _context.Clients.Add(newClient);
        _context.SaveChanges();

        return newClient;
    }
}
