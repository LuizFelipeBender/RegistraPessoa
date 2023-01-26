using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace RegistraPessoa.Api.Model.Base.PessoaBase
{
    [Table("Tabela_Pessoa")]

    public class Pessoa : BaseEntity
    {
        //Cpf
        [PersonalData]
        public string Cpf { get; set; }

        //Nome
        [PersonalData]
        [Column("NOME_COMPLETO")]
        public string Nome { get; set; }

        //Email
        [PersonalData]
        [Column("E-MAIL")]
        public string? Email { get; set; }

        //Idade
        [Column("IDADE")]
        public uint Idade { get; set; }

        //Registro criado hein
        [Column("DATA_DA_CRIACAO")]
        public DateTime? DataDeCriacao {get;set;}

        [PersonalData]
        [Column("TELEFONE")]
        public string ?Telefone { get; set; }

        [Column("URL_IMAGEM_PERFIL")]
        public string? ImageUrlPerfil { get; set; }
    }
}