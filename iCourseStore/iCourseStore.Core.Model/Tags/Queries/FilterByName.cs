using iCourseStore.Model.Framework;
using iCourseStore.Model.Tags.DTOs;
using MediatR;

namespace iCourseStore.Model.Tags.Queries;

public class FilterByName : IRequest<ApplicationServiceResponse<List<TagQr>>>
{
    public string? TagName { get; set; }
}
