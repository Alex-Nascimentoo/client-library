using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fullstack.src.Models;

public class Contract
{
    public Contract()
    {
        Title = "";
        Description = "";
        Price = 0;
        Paid = false;
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int Price { get; set; }

    public bool Paid { get; set; }

    public int ClientId { get; set; }
}