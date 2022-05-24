using iCourseStore.YFereidouni.BLL.Framework;
using iCourseStore.YFereidouni.DAL.CourseStoreDB;
using iCourseStore.YFereidouni.DAL.Tags;
using iCourseStore.YFereidouni.Model.Tags.DTOs;
using iCourseStore.YFereidouni.Model.Tags.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCourseStore.YFereidouni.BLL.Tags.Queries;

public class FilterByNameHandler : BaseApplicationServiceHandler<FilterByName, List<TagQr>>
{
    public FilterByNameHandler(CourseStoreDbContext courseStoreDbContext) : base(courseStoreDbContext)
    {
    }

    protected override async Task HandleRequest(FilterByName request, CancellationToken cancellationToken)
    {
        #region OldVersion

        //var tags = courseStoreDbContext.Tags.AsQueryable();
        //if (!string.IsNullOrEmpty(request.TagName))
        //    tags = tags.Where(t => t.TagName.Contains(request.TagName));

        //var result = await tags.Select(c => new TagQr
        //{
        //    Id = c.Id,
        //    TagName = c.TagName,
        //}).ToListAsync();

        #endregion

        #region Refatored

        var result = await courseStoreDbContext.Tags.WhereOver(request.TagName).ToTagQrAsync();
        AddResult(result);

        #endregion
    }
}
