using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Client.Models
{
    public class Sessao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, preencha a data do agendamento!")]
        [DisplayName("Data")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o valor da sessao!")]
        [DisplayName("Valor")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o cliente da sessao!")]
        [DisplayName("Cliente")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Por favor, preencha a forma de pagamento da sessao!")]
        [DisplayName("Forma de Pagamento")]
        public int FormaPagamentoId { get; set; }


        public virtual Cliente Cliente { get; set; }
        public virtual Pagamento FormaPagamento { get; set; }
    }
}
