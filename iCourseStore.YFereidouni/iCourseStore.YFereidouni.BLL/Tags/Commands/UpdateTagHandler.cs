using iCourseStore.YFereidouni.BLL.Framework;
using iCourseStore.YFereidouni.DAL.CourseStoreDB;
using iCourseStore.YFereidouni.Model.Framework;
using iCourseStore.YFereidouni.Model.Tags.Commands;
using iCourseStore.YFereidouni.Model.Tags.Entities;

namespace iCourseStore.YFereidouni.BLL.Tags.Commands;

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


#region Refactored-UpdateHandler

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