using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using fullstack.src.Persistence;
using fullstack.src.Models;

namespace fullstack.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractController : ControllerBase
    {
        private Context _context { get; set; }

        public ContractController(Context context)
        {
            _context = context;
        }

        // Get /api/Contract
        [HttpGet]
        public List<Contract> Get()
        {
            return _context.Contracts.ToList<Contract>();
        }

        // Post /api/Contract/[ClientId]
        [HttpPost("{ClientId}")]
        public Contract Post([FromRoute]int ClientId, [FromBody]Contract newContract)
        {
            newContract.ClientId = ClientId;
            _context.Contracts.Add(newContract);
            _context.SaveChanges();

            return newContract;
        }
    }
}