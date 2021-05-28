using Microsoft.AspNetCore.Mvc;

namespace dotnet5_masstransit_rabbitmq
{


    [Route("api/controller")]
    public class PropostaController : Controller
    {
        //private readonly DbContext _context;

        public PropostaController()
        {
            //_context = context;
        }

        [HttpPost]
        public ActionResult CadastrarProposta()
        {

            return Ok();
        }
    }
}
