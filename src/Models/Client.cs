using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fullstack.src.Models;

public class Client
{
    public Client()
    {
        Name = "";
        Email = "";
        Contracts = new List<Contract>();
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public List<Contract> Contracts { get; set; }
}
