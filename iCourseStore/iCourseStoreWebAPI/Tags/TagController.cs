using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using iCourseStoreWebAPI.Framework;
using iCourseStore.Model.Tags.Commands;
using iCourseStore.Model.Tags.Queries;

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
        
        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpPut("UpdateTag")]
    public async Task<IActionResult> UpdateTag(UpdateTag tag)
    {
        var response = await mediator.Send(tag);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpGet("FilterByName")]
    public async Task<IActionResult> SearchTag([FromQuery]FilterByName tag)
    {
        var response = await mediator.Send(tag);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }
}
