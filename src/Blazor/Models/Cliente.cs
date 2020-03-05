using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.Client.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o nome!")]
        [StringLength(60, MinimumLength = 4,
            ErrorMessage = "O nome deve ter no minimo 4 e no maximo 60 caracteres!")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o RG!")]
        [StringLength(9)]
        [DisplayName("RG")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o CPF!")]
        [StringLength(11, ErrorMessage = "O CPF deve conter 11 digitos")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o Endereco!")]
        [StringLength(60)]
        [DisplayName("Endereco")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o Telefone!")]
        [StringLength(11)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o Celular!")]
        [StringLength(12)]
        [DisplayName("Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Por favor, preencha o email!")]
        [EmailAddress(ErrorMessage = "Email invalido!")]
        [StringLength(60)]
        [DisplayName("Email")]
        public string Email { get; set; }

    }
}
