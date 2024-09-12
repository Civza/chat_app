using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chat_app_backend.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase {
        [HttpPost("messages")]
        public IActionResult Index() {

        }
    }
}
