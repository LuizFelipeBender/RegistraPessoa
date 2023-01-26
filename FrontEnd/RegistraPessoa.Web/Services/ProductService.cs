using RegistraPessoa.Web.Models;
using RegistraPessoa.Web.Services.IServices;
using RegistraPessoa.Web.Utils;

namespace RegistraPessoa.Web.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/Pessoa";

        public PessoaService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<PessoaModel>> FindAllPessoas()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<PessoaModel>>();
        }

        public async Task<PessoaModel> FindPessoaById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<PessoaModel>();
        }

        public async Task<PessoaModel> CreatePessoa(PessoaModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<PessoaModel>();
            else throw new Exception("Something went wrong when calling API");
        }
        public async Task<PessoaModel> UpdatePessoa(PessoaModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<PessoaModel>();
            else throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> DeletePessoaById(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else throw new Exception("Something went wrong when calling API");
        }
    }
}
