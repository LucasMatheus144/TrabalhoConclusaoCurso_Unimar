using Microsoft.AspNetCore.Mvc;
using Unimar.Console.Entidade;
using Unimar.Dominio.Interfaces;

namespace Unimar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorServico _servico;

        public ProfessorController(IProfessorServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public async Task<IActionResult> IncluirProfessor([FromBody] Professor professor)
        {
            var resultado = await _servico.Adicionar(professor);

            return resultado.Sucesso ? Ok(resultado) : UnprocessableEntity(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> ListarProfessores(
            [FromQuery] string? disciplina,
            [FromQuery] bool? ativo,
            [FromQuery] bool ordenarPorNome = false,
            [FromQuery] int? limite = null)
        {
            var resultado = await _servico.Buscar(disciplina, ativo, ordenarPorNome, limite);
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterProfessorPorId(Guid id)
        {
            var resultado = await _servico.GerPorId(id);
            return resultado != null ? Ok(resultado) : NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> EditarProfessor([FromBody] Professor professor)
        {
            var resultado = await _servico.Atualizar(professor);
            return resultado.Sucesso ? Ok(resultado) : UnprocessableEntity(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirProfessor(Guid id)
        {
            var resultado = await _servico.Excluir(id);
            return resultado ? Ok(resultado) : UnprocessableEntity(resultado);
        }

        
    }
}
