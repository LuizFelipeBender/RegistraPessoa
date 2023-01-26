namespace RegistraPessoa.Web.Models
{
    public class PessoaModel
    {
        public string ?Cpf { get; set; }
        public string ?Nome { get; set; }
        public string ?Email { get; set; }
        public uint Idade { get; set; }
        public string ?Telefone { get; set; }
        public string ?ImageUrlPerfil { get; set; }
        public ulong Id { get; set; }

        public DateTime DataDeCriacao { get; set; }

    }
}