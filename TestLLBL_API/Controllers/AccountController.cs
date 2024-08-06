using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestLLBL.DatabaseSpecific;
using TestLLBL.Linq;

namespace TestLLBL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAccounts()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var accounts = metaData.Account.ToList();
                return Ok(accounts);
            }
        }
    }
}
