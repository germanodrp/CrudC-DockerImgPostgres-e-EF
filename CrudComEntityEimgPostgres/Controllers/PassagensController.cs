using CrudComEntityEimgPostgres.Context;
using CrudComEntityEimgPostgres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudComEntityEimgPostgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassagensController : ControllerBase
    {
        private readonly PassagensContext  _passagensContext;
        public PassagensController(PassagensContext passagensContext)
        {
            _passagensContext = passagensContext;
        }

        [HttpGet]
        [Route("BuscarTodasPassagens")]
        public async Task<ActionResult<List<PassagensUsuarios>>> BuscarTodasPassagens()
        {
            var buscarTodasPassagnes = _passagensContext.Passagens.ToList();

            return Ok(buscarTodasPassagnes);
        }

        [HttpGet]
        [Route("BuscarPassagemPorId/{id}")]
        public async Task<ActionResult<PassagensUsuarios>>BuscarPassagemPorId(int id)
        {
            var buscarPassagemPorId = _passagensContext.Passagens.Find(id);

            return Ok(buscarPassagemPorId);
        }

        [HttpPost]
        [Route("AdicionarPassagem")]
        public async Task<ActionResult<string>> AdicionarPassagemUsuario([FromBody]PassagensUsuarios passagens)
        {
            _passagensContext.Passagens.Add(passagens);
            _passagensContext.SaveChanges();

            return Ok("Passagem cadastrada com sucesso!");
        }


        [HttpPut]
        [Route("AtualizarPassagem/{id}")]
        public async Task<ActionResult<string>> AtualizarPassagemUsuario(PassagensUsuarios passagensUsuarios, int id)
        {

            if(passagensUsuarios.Id != id)
            {
                return NotFound("Passagem não encontrada!");
            }

           

            _passagensContext.Passagens.Update(passagensUsuarios);
            _passagensContext.SaveChanges();

            return Ok("Passagem Atualizada!");
        }


        [HttpDelete]
        [Route("DeletarPassagem/{id}")]
        public async Task<ActionResult<string>>DeletarPassagem(int id)
        {
            if(id == null)
            {
                return NotFound("Passagem não encontra,Favor verificar as credenciais!!");
            }
            var excluirPassagem = _passagensContext.Passagens.Find(id);

            _passagensContext.Passagens.Remove(excluirPassagem);
            _passagensContext.SaveChanges();

            return Ok("Passagem excluida com sucesso!!");
        }

    }
}
