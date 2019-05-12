

using Microsoft.AspNetCore.Mvc;
using treinamento.webapi.Models;
using treinamento.webapi.Repositories;

namespace treinamento.webapi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Pessoa pessoa)
        {
            PessoaRepository.AdicionarPessoa(pessoa);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pessoas = PessoaRepository.RetornarPessoas();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pessoa = PessoaRepository.RetornarPessoa(id);

            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] Pessoa pessoa)
        {
            pessoa = PessoaRepository.AtualizarPessoa(id, pessoa);

            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }

    }
}