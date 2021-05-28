using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet5_masstransit_rabbitmq
{

    [Route("api/proposta")]
    [ApiController]
    public class PropostaController : Controller
    {
        private readonly DbContext _context;

        public PropostaController()
        {
        }

        [HttpPost]
        public ActionResult CadastrarProposta([FromBody] DTOProposta proposta)
        {
            //_context.Add(proposta);
            //_context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public ActionResult ConsultarProposta()
        {
            return Ok();
        }
    }
}
