using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iCourseStore.YFereidouni.WebAPI.Framework;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController : ControllerBase
{
    protected readonly IMediator mediator;

    public BaseController(IMediator mediator)
    {
        this.mediator = mediator;
    }
}
