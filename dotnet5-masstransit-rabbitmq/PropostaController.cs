using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet5_masstransit_rabbitmq
{

    [Route("api/proposta")]
    [ApiController]
    public class PropostaController : Controller
    {
        private readonly ApplicationContext _context;

        public PropostaController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult CadastrarProposta([FromBody] Proposta proposta)
        {
            _context.Add(proposta);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public ActionResult ConsultarProposta()
        {
            return Ok();
        }
    }
}
