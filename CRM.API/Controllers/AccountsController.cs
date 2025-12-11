using CRM.API.Contract.Response;
using CRM.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    public class AccountsController : APIControllerBase
    {
        [HttpGet()]
        public async Task<ActionResult<Envelope<string>>> HelloWorld()
        {
            return Ok(Envelope.Ok("Hello World from AccountsController"));
        }
    }
}
