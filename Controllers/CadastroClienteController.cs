using System;
using System.Linq;
using System.Text;
using CadastroCliente.Data;
using CadastroCliente.Helpers;
using CadastroCliente.Methods;
using CadastroCliente.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CadastroCliente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroClienteController : ControllerBase
    {
        private readonly ILogger<CadastroClienteController> _logger;
        public CadastroClienteController(ILogger<CadastroClienteController> logger)
        {
            _logger = logger;
        }



        [HttpGet("ListarClientes")]
        public IActionResult ListarClientes()
        {
            var getClientes = new ListarDadosCliente();

            if (getClientes.ListarDados() != null)
            {
                return Ok(getClientes.ListarDados());
            }

            return NotFound("Clientes não encontrados");
        }

        [HttpPost("AdicionarCliente")]
        public IActionResult AdicionarCliente([FromBody] Cliente model)
        {
            var postClientes = new InserirDadosCliente();

            if (postClientes != null)
            {
                return Ok(postClientes.InserirDados(model.Nome, model.DataNascimento, model.Sexo, model.Cep, model.Endereco, model.Numero, model.Complemento, model.Bairro, model.Estado, model.Cidade));
            }

            return BadRequest(Messages.CLIENTE_FALTANDO_DADOS);
        }

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
