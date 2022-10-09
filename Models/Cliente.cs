using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Trabalho_Final.Models
{
    public class Cliente
    {
        [Key]
        public int NrCliente { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string CodPostal { get; set; }
        public string Localidade { get; set; }
        public string Telefone { get; set; } 
        public string Email { get; set; }
        public string NrContribuinte { get; set; }
        public float SaldoDisponivel { get; set; }
        public DateTime ValidadeSaldo { get; set; }
        // public Blob Avatar { get; set; }
    }
}
