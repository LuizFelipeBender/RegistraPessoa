using RegistraPessoa.Api.Data.ValueObjects;

namespace RegistraPessoa.Api.Repository
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<PessoaVO>> FindAllAsync();
        Task<PessoaVOtotal> FindById(ulong id);
        Task<PessoaVO> CreateAsync(PessoaVO vo);
        Task<PessoaVO> UpdateAsync(PessoaVO vo);
        Task<bool>  DeleteAsync(ulong vo);
    }
}