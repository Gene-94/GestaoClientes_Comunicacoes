using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_Final.Models
{
    public class Cartao
    {
        [Key]
        public int Nr_Cartao { get; set; }
        [ForeignKey("Cliente")]
        public int Nr_Cliente { get; set; }
        public float Saldo { get; set; }
        public DateTime Validade { get; set; }

    }
}
