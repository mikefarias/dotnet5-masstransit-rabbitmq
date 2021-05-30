using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace dotnet5_masstransit_rabbitmq
{

    [Route("api/proposta")]
    [ApiController]
    public class PropostaController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IPublishEndpoint _publish;

        public PropostaController(ApplicationContext context, IPublishEndpoint publish)
        {
            _context = context;
            _publish = publish;
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarPropostaAsync([FromBody] Proposta proposta)
        {
            //_context.Add(proposta);
            //_context.SaveChanges();

            // Publicando Mensagem na Fila
            try {

                await _publish.Publish<PropostaMessage>(new
                {
                    Id = proposta.Id,
                    CPF = proposta.CPF,
                    CodigoProduto = proposta.CodigoProduto,
                    LimiteCredito = proposta.LimiteCredito,
                    Aprovado = proposta.Aprovado

                });
                return Ok();
            }
            catch (ArgumentException e)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public ActionResult ConsultarProposta()
        {
            return Ok();
        }
    }
}
