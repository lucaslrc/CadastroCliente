using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroCliente.Data;
using CadastroCliente.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadastroCliente.Methods;

namespace CadastroCliente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroClienteController : ControllerBase
    {
        private readonly ILogger<CadastroClienteController> _logger;

        private readonly ClienteContext _context;

        public CadastroClienteController(ILogger<CadastroClienteController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ListarClientes")]
        public async Task<ActionResult> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (_context)
            {
                clientes = _context.Clientes.OrderBy(x => x.ID).ToList();

                if (clientes != null )
                {
                    return Ok(clientes.ToString());
                }

                return NotFound("Clientes não encontrados.");
            }
        }

        // [HttpPost("AdicionarCliente")]
        // public IActionResult AdicionarCliente()
        // {
        //     return null;
        // }

        // [HttpPut("EditarCliente")]
        // public IActionResult EditarCliente()
        // {
        //     return null;
        // }

        // [HttpDelete("RemoverCliente")]
        // public IActionResult RemoverCliente()
        // {
        //     return null;
        // }
    }
}
