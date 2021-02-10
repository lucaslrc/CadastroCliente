using System;
using System.Linq;
using System.Text;
using CadastroCliente.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CadastroCliente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroClienteController : ControllerBase
    {
        private readonly ILogger<CadastroClienteController> _logger;

        private readonly ClienteContext _context = new ClienteContext();

        public CadastroClienteController(ILogger<CadastroClienteController> logger)
        {
            _logger = logger;
        }



        [HttpGet("ListarClientes")]
        public IActionResult ListarClientes()
        {
            using (_context)
            {
                var clientes = _context.Clientes.FirstOrDefault(x => x.ID == 1).Nome.ToString();
                

                if (!String.IsNullOrEmpty(clientes))
                {
                    return Ok(clientes);
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
