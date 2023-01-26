using RegistraPessoa.Web.Models;

namespace RegistraPessoa.Web.Services.IServices
{
    public interface IPessoaService
    {
        Task<IEnumerable<PessoaModel>> FindAllPessoas();
        Task<PessoaModel> FindPessoaById(long id);
        Task<PessoaModel> CreatePessoa(PessoaModel model);
        Task<PessoaModel> UpdatePessoa(PessoaModel model);
        Task<bool> DeletePessoaById(long id);
    }
}
