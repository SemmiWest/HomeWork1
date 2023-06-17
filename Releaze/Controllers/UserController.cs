using Microsoft.AspNetCore.Mvc;

namespace Releaze.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public List<string> GetUsers()
        {
            return new List<string>();
            
        }
    }
}
