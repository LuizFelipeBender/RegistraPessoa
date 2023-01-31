using System.ComponentModel.DataAnnotations;

namespace RegistraPessoa.Api.Data.ValueObjects
{
    public class PessoaVOtotal:PessoaVO
    {  
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public ulong Id {get; set; }

        public DateTime DataDeCriacao {get;set;}

    }
}