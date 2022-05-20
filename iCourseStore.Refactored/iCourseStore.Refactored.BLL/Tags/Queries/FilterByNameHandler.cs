using iCourseStore.BLL.Framework;
using iCourseStore.DAL.CourseStoreDB;
using iCourseStore.DAL.Tags;
using iCourseStore.Model.Tags.DTOs;
using iCourseStore.Model.Tags.Queries;
using Microsoft.EntityFrameworkCore;

namespace iCourseStore.BLL.Tags.Queries;

public class FilterByNameHandler : BaseApplicationServiceHandler<FilterByName, List<TagQr>>
{
    public FilterByNameHandler(CourseStoreDbContext courseStoreDbContext) : base(courseStoreDbContext) { }

    protected override async Task HandlerRequest(FilterByName request, CancellationToken cancellationToken)
    {
        var result = await courseStoreDbContext.Tags.WhereOver(request.TagName).ToTagQrAsync();
        
        AddResult(result);
    }
}
