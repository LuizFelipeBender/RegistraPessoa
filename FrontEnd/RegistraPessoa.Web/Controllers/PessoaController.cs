using Microsoft.AspNetCore.Mvc;
using RegistraPessoa.Web.Models;
using RegistraPessoa.Web.Services.IServices;

namespace RegistraPessoa.Web.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaService _productService;

        public PessoaController(IPessoaService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> PessoaIndex()
        {
            var products = await _productService.FindAllPessoas();
            return View(products);
        }

        public async Task<IActionResult> PessoaCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PessoaCreate(PessoaModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.CreatePessoa(model);
                if (response != null) return RedirectToAction(
                     nameof(PessoaIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> PessoaUpdate(int id)
        {
            var model = await _productService.FindPessoaById(id);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> PessoaUpdate(PessoaModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.UpdatePessoa(model);
                if (response != null) return RedirectToAction(
                     nameof(PessoaIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> PessoaDelete(int id)
        {
            var model = await _productService.FindPessoaById(id);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> PessoaDelete(PessoaModel model)
        {
            var response = await _productService.DeletePessoaById((long)model.Id);
            if (response) return RedirectToAction(
                    nameof(PessoaIndex));
            return View(model);
        }
    }
}