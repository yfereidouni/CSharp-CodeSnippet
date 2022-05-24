using iCourseStore.YFereidouni.BLL.Framework;
using iCourseStore.YFereidouni.DAL.CourseStoreDB;
using iCourseStore.YFereidouni.Model.Framework;
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

#region Old_UpdateTagHandler
//public class UpdateTagHandler : IRequestHandler<UpdateTag, ApplicationServiceResponse<Tag>>
//{
//    private readonly CourseStoreDbContext courseStoreDbContext;

//    public UpdateTagHandler(CourseStoreDbContext courseStoreDbContext)
//    {
//        this.courseStoreDbContext = courseStoreDbContext;
//    }

//    public async Task<ApplicationServiceResponse<Tag>> Handle(UpdateTag request, CancellationToken cancellationToken)
//    {
//        ApplicationServiceResponse<Tag> response = new();

//        Tag tag = courseStoreDbContext.Tags.SingleOrDefault(c => c.Id == request.Id);

//        if (tag == null)
//        {
//            response.AddError($"تگ با شناسه {request.Id} یافت نشد.");
//        }
//        else
//        {
//            tag.TagName = request.TagName;
//            await courseStoreDbContext.SaveChangesAsync();
//            response.Result = tag;
//        }

//        return response;
//    }
//}
#endregion

public class UpdateTagHandler : BaseApplicationServiceHandler<UpdateTag, Tag>
{
    public UpdateTagHandler(CourseStoreDbContext courseStoreDbContext) : base(courseStoreDbContext) { }

    protected override async Task HandleRequest(UpdateTag request, CancellationToken cancellationToken)
    {
        ApplicationServiceResponse<Tag> response = new();

        Tag tag = courseStoreDbContext.Tags.SingleOrDefault(c => c.Id == request.Id);

        if (tag == null)
        {
            AddError($"تگ با شناسه {request.Id} یافت نشد.");
        }
        else
        {
            tag.TagName = request.TagName;
            await courseStoreDbContext.SaveChangesAsync();
            AddResult(tag);
        }

        AddResult(tag);

    }
}
#endregion