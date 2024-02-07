using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UrlShorter.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:ApiVersion}/[Controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ?? HttpContext.RequestServices.GetService<IMediator>();
    }
}
