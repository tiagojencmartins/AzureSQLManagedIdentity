using AzureSQLManagedIdentity.Database;
using Microsoft.AspNetCore.Mvc;

namespace AzureSQLManagedIdentity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        public EntryController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Index()
        {
            return Ok($"Is database available: {await _databaseContext.Database.CanConnectAsync()}");
        }
    }
}
