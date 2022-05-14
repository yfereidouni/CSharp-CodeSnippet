using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using iCourseStoreWebAPI.Framework;
using iCourseStore.Model.Tags.Commands;

namespace iCourseStoreWebAPI.Tags;

//[Route("api/[controller]")]
//[ApiController]
public class TagController : BaseController
{
    public TagController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("CreateTag")]
    public async Task<IActionResult> CreateTag(CreateTag tag)
    {
        var response = await mediator.Send(tag);
        
        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Result);
    }
}
