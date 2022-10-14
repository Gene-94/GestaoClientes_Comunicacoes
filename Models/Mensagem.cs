using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_Final.Models
{
    public class Mensagem
    {
        [Key]
        public int Id_Mensagem { get; set; }

        [ForeignKey("Cartao")]
        public int Origem { get; set; }

        [ForeignKey("Cartao")]
        public int Destino { get; set; }

        public DateTime Data_Envio { get; set; }

        public string Conteudo { get; set; }



    }
}
