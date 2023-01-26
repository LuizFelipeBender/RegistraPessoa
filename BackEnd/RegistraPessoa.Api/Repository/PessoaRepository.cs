using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RegistraPessoa.Api.Data.ValueObjects;
using RegistraPessoa.Api.Model.Base.PessoaBase;
using RegistraPessoa.Api.Model.Context;

namespace RegistraPessoa.Api.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;

        public PessoaRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PessoaVO>> FindAllAsync()
        {
            List<Pessoa> pessoas = await _context.Pessoas.ToListAsync();
            return _mapper.Map<List<PessoaVO>>(pessoas);
        }

        public async Task<PessoaVO> FindById(ulong id)
        {
            Pessoa pessoa = await _context.Pessoas.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<PessoaVO>(pessoa);
        }

        public async Task<PessoaVO> CreateAsync(PessoaVO vo)
        {
            Pessoa pessoa = _mapper.Map<Pessoa>(vo);
            _context.Pessoas.Add(pessoa);
            pessoa.DataDeCriacao = DateTime.Now;
            await _context.SaveChangesAsync();
            return _mapper.Map<PessoaVO>(pessoa);
        }

        public async Task<PessoaVO> UpdateAsync(PessoaVO vo)
        {
            Pessoa pessoa = _mapper.Map<Pessoa>(vo);
            _context.Pessoas.Update(pessoa);
            await _context.SaveChangesAsync();
            return _mapper.Map<PessoaVO>(pessoa);
        }

        
        public async Task<bool> DeleteAsync(ulong id)
        {
            try
            {
                Pessoa pessoa = await _context.Pessoas.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
                if (pessoa == null) return false;
                _context.Pessoas.Remove(pessoa);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        async Task<PessoaVOtotal> IPessoaRepository.FindById(ulong id)
        {
          Pessoa pessoa = await _context.Pessoas.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<PessoaVOtotal>(pessoa);
        }
    }
}