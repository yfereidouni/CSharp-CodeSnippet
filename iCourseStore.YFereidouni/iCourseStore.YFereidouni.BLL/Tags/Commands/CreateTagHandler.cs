using iCourseStore.YFereidouni.BLL.Framework;
using iCourseStore.YFereidouni.DAL.CourseStoreDB;
using iCourseStore.YFereidouni.Model.Tags.Commands;
using iCourseStore.YFereidouni.Model.Tags.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCourseStore.YFereidouni.BLL.Tags.Commands;

//BaseApplicationServiceHandler

#region Old-CreateHandler
//public class CreateTagHandler : IRequestHandler<CreateTag, ApplicationServiceResponse<Tag>>
//{
//    private readonly CourseStoreDbContext courseStoreDbContext;

//    public CreateTagHandler(CourseStoreDbContext courseStoreDbContext)
//    {
//        this.courseStoreDbContext = courseStoreDbContext;
//    }

//    public async Task<ApplicationServiceResponse<Tag>> Handle(CreateTag request, CancellationToken cancellationToken)
//    {
//        Tag tag = new()
//        {
//            TagName = request.TagName,
//        };
//        await courseStoreDbContext.AddAsync(tag);
//        await courseStoreDbContext.SaveChangesAsync();

//        return new ApplicationServiceResponse<Tag>
//        {
//            Result = tag
//        };
//    }
//}
#endregion

#region Refactored-CreateHandler
public class CreateTagHandler : BaseApplicationServiceHandler<CreateTag, Tag>
{
    public CreateTagHandler(CourseStoreDbContext courseStoreDbContext) : base(courseStoreDbContext) { }

    protected override async Task HandleRequest(CreateTag request, CancellationToken cancellationToken)
    {
        Tag tag = new()
        {
            TagName = request.TagName,
        };
        await courseStoreDbContext.AddAsync(tag);
        await courseStoreDbContext.SaveChangesAsync();

        AddResult(tag);
    }
}
#endregion