using Application.Features.ShortenUrl.Commands.CreateShortenUrlCommand;
using Microsoft.AspNetCore.Mvc;

namespace UrlShorter.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ShortenUrlController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreateShortenUrlCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
