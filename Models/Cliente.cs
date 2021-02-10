using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.EntityFrameworkCore;

namespace CadastroCliente.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Sexo { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public double Cep { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Endereco { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Numero { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Complemento { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Bairro { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Estado { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Cidade { get; set; }
    }
}