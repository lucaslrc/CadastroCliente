using System;
using System.Linq;
using System.Text.Json;
using CadastroCliente.Data;

namespace CadastroCliente.Methods
{
    public class ListarDadosCliente
    {
        private readonly ClienteContext _context = new ClienteContext();
        public string ListarDados()
        {
            var clientes = _context.Clientes.OrderBy(x => x.ID).ToArray().ToList();

            string jsonObj = JsonSerializer.Serialize(clientes);

            if (!String.IsNullOrEmpty(jsonObj))
            {
                return jsonObj;
            }
            return null;
        }
    }
}