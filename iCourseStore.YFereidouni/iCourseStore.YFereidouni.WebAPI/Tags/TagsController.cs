using iCourseStore.YFereidouni.DAL.CourseStoreDB;
using iCourseStore.YFereidouni.Model.Tags.Commands;
using iCourseStore.YFereidouni.Model.Tags.Queries;
using iCourseStore.YFereidouni.WebAPI.Framework;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace iCourseStore.YFereidouni.WebAPI.Tags;

//[Route("api/[controller]")]
//[ApiController]
public class TagsController : BaseController
{
    public TagsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("CreateTag")]
    public async Task<IActionResult> CreateTag(CreateTag tag)
    {
        var response = await mediator.Send(tag);

        if (response.IsSuccess)
            return Ok(response.Result);
        else
            return BadRequest(response.Errors);

        //return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
  
    }

    [HttpPut("UpdateTag")]
    public async Task<IActionResult> UpdateTag(UpdateTag tag)
    {
        var response = await mediator.Send(tag);

        if (response.IsSuccess)
            return Ok(response.Result);
        else
            return BadRequest(response.Errors);

        //return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);

    }

    [HttpGet("FilterByName")]
    public async Task<IActionResult> SearchTag([FromQuery]FilterByName tag)
    {
        var response = await mediator.Send(tag);

        if (response.IsSuccess)
            return Ok(response.Result);
        else
            return BadRequest(response.Errors);

        //return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);

    }

}
