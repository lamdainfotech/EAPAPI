using System.Linq;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.Wrapper;
using EAP.Shared.SendEmail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EAP.API.Controllers.Api.SendEmail
{
    [ApiController]
    [Route("Api/[controller]")]
    public class SendEmailsController : ControllerBase
    {
        private readonly IWrapperRepo _repo;

        public SendEmailsController(IWrapperRepo repo)
        {
            this._repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var message = new Message(new string[]
            {"sharmakharel91@gmail.com"}, "Test Email async", "This is an test email async", null);

            await _repo.sender.SendEmailAsync(message);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> SendAttachment()
        {
            var files = Request.Form.Files.Any() ? Request.Form.Files : new FormFileCollection();
            var message = new Message(new string[]
            {
                "sharmakharel91@gmail.com",
                "tapansharm59@outlook.com",
                "tapansharma91@outlook.com"
            },
                "Test Email With Attachment", "This is an test email With Attachment", files);

            await _repo.sender.SendEmailAsync(message);
            return Ok();
        }
    }

}