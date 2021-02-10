using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using CadastroCliente.Data;
using CadastroCliente.Models;

namespace CadastroCliente
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InserirDadosIniciais();
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
            using (var _context = new ClienteContext())
            {
                if (_context.Database.CanConnect())
                {
                    if (_context.Database.EnsureCreated())
                    {
                        Console.WriteLine("The Database has been created before.");

                        //Dados para teste da base
                        _context.Clientes.Add(new Cliente {
                            Nome = "Cliente Teste",
                            DataNascimento = new DateTime(1999, 01, 01){},
                            Sexo = "Masculino",
                            Cep = "01001000",
                            Endereco = "Praça da Sé",
                            Numero = "123",
                            Complemento = "lado ímpar",
                            Bairro = "Sé",
                            Estado = "SP",
                            Cidade = "São Paulo"
                        });  

                        _context.Clientes.Add(new Cliente {
                            Nome = "Cliente Teste 2",
                            DataNascimento = new DateTime(1999, 01, 01){},
                            Sexo = "Masculino",
                            Cep = "01001000",
                            Endereco = "Praça da Sé",
                            Numero = "123",
                            Complemento = "lado ímpar",
                            Bairro = "Sé",
                            Estado = "SP",
                            Cidade = "São Paulo"
                        });

                        Console.WriteLine("Test datas was added in database.");

                        _context.SaveChanges();
                    }

                    Console.WriteLine("Database is running...");
                }
            }
        }
    }
}
