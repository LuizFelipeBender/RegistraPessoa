using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace RegistraPessoa.Api.Data.ValueObjects
{
    public class PessoaVO
    {

        [PersonalData]
        [Column("CPF")]
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "{0} é um campo obrigatorio")]
        [StringLength(11, MinimumLength = 11, ErrorMessage ="O cpf deve conter apenas 11 dígitos")]
        public string ?Cpf { get; set; }

        //Nome
        [PersonalData]
        [Column("NOME_COMPLETO")]
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,80}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        //Email
        [PersonalData]
        [Column("E-MAIL")]
        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 100 caracteres.")]
        [EmailAddress(ErrorMessage = "Formato do email inválido")]
        public string? Email { get; set; }

        //Idade
        [Column("IDADE")]
        [Range(0, 120)]
        [Required(ErrorMessage = "A idade deve estar entre {0} e {1} anos.")]
        [Display(Name = "Idade", Description = "A idade deve estar entre {0} e {1} anos.")]
        public uint Idade { get; set; }

        [PersonalData]
        [Column("TELEFONE")]
        [Display(Name = "Telefone", Description = "Telefone deve ser prenchido")]
        [Required(ErrorMessage = "Telefone deve ser prenchido.")]
        public string ?Telefone { get; set; }

        [Column("URL_IMAGEM_PERFIL")]
        [Required(ErrorMessage = "A idade deve estar entre {0} e {1} anos.")]

        [StringLength(500)]
        public string? ImageUrlPerfil { get; set; }


     
    }
}