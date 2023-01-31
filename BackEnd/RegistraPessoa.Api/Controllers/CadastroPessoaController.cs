using Microsoft.AspNetCore.Mvc;
using RegistraPessoa.Api.Data.ValueObjects;
using RegistraPessoa.Api.Repository;

namespace RegistraPessoa.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private IPessoaRepository _repository;

        public PessoaController(IPessoaRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaVO>>> GetAll()
        {
            var pessoas = await _repository.FindAllAsync();
            pessoas.Count();
            if (pessoas.Count() == 0)
            {
                Response.StatusCode = 404;
                return NotFound(new { msg = "Person not found" });
            }
            return Ok(pessoas);
        }


      
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(ulong id)
        {
            var pessoa = await _repository.FindById(id);
            if (pessoa == null)
            {
                Response.StatusCode = 404;
                return NotFound(new { msg = "Person not found" });
            }
            return Ok(pessoa);
        }

        [HttpPost]

        public async Task<ActionResult<PessoaVO>> Create([FromForm] PessoaVO pessoaVO)
        {
            if (pessoaVO == null) return BadRequest();
            var pessoa = await _repository.CreateAsync(pessoaVO);
            return Ok(pessoa);
        }

        [HttpPut]
        public async Task<ActionResult<PessoaVO>> UpdatePessoa([FromForm] PessoaVO pessoaVO)
        {
            if (pessoaVO == null) return BadRequest();
            var pessoa = await _repository.UpdateAsync(pessoaVO);
            return Ok(pessoa);
        }

        [HttpPatch]
        public async Task<ActionResult<PessoaVO>> UpdatesPessoas([FromForm] PessoaVOtotal pessoaVO){
            if(pessoaVO.Id >0){
                try
                {
                var pessoa = await _repository.UpdateAsync(pessoaVO);//
                return Ok(pessoa);
                }
                catch 
                {
                    Response.StatusCode = 400;
                    return new ObjectResult(new {msg = "Pessoa não encontrada"});
                   
                }
            }
                    return new ObjectResult(new {msg = "Pessoa não encontrada"});
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<PessoaVO>> Delete(ulong id)
        {
            var status = await _repository.DeleteAsync(id);
            if (!status) return BadRequest();
            return Ok("Produto excluido");
        }
    }
}