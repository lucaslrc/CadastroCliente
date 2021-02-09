using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CadastroCliente.Data;
using CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CadastroCliente
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InserirDadosIniciais();
            MostrarDadosIniciais();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void InserirDadosIniciais()
        {
            using (var ctx = new ClienteContext())
            {
                if (ctx.Database.EnsureCreated())
                {
                    //Dados para teste da base
                    ctx.Clientes.Add(new Cliente {
                        ID = 1,
                        Nome = "Cliente Teste",
                        DataNascimento = new DateTime(1999, 01, 01){},
                        Sexo = "Masculino",
                        Cep = 01001000,
                        Endereco = "Praça da Sé",
                        Numero = 123,
                        Complemento = "lado ímpar",
                        Bairro = "Sé",
                        Estado = "SP",
                        Cidade = "São Paulo"
                    });   
                    
                    Console.WriteLine("Database created and test data was added.");

                    ctx.SaveChanges();
                }

                Console.WriteLine("Running context...");
            }
        }

        public static void MostrarDadosIniciais()
        {
            using (var ctx = new ClienteContext())
            {
                
            }
        }
    }
}
