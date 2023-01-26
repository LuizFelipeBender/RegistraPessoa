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
            var products = await _repository.FindAllAsync();
            products.Count();
            if (products.Count() == 0)
            {
                Response.StatusCode = 404;
                return NotFound(new { msg = "Person not found" });
            }
            return Ok(products);
        }


        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromQuery] uint id)
        {
            var product = await _repository.FindById(id);
            if (product == null)
            {
                Response.StatusCode = 404;
                return NotFound(new { msg = "Person not found" });
            }
            return Ok(product);
        }

        [HttpPost]

        public async Task<ActionResult<PessoaVO>> Create([FromForm] PessoaVO productVO)
        {
            if (productVO == null) return BadRequest();
            var product = await _repository.CreateAsync(productVO);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<PessoaVO>> UpdatePessoa([FromForm] PessoaVO productVO)
        {
            if (productVO == null) return BadRequest();
            var product = await _repository.UpdateAsync(productVO);
            return Ok(product);
        }

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]

        public async Task<ActionResult<PessoaVO>> Delete(uint id)
        {
            var status = await _repository.DeleteAsync(id);
            if (!status) return BadRequest();
            return Ok("Produto excluido");
        }
    }
}