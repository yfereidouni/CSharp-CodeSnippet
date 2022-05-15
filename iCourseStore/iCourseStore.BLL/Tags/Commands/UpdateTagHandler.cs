using iCourseStore.BLL.Framework;
using iCourseStore.DAL.CourseStoreDB;
using iCourseStore.Model.Tags.Commands;
using iCourseStore.Model.Tags.Entities;

namespace iCourseStore.BLL.Tags.Commands;

public class UpdateTagHandler : BaseApplicationServiceHandler<UpdateTag, Tag>
{
    public UpdateTagHandler(CourseStoreDbContext courseStoreDbContext) : base(courseStoreDbContext)
    {
    }

    protected override async Task HandlerRequest(UpdateTag request, CancellationToken cancellationToken)
    {
        Tag tag = courseStoreDbContext.Tags.SingleOrDefault(c => c.Id == request.Id);
        if (tag == null)
        {
            AddError($"تگ {request.Id} یافت نشد.");
            await courseStoreDbContext.SaveChangesAsync();
        }
        else
        {
            tag.TagName = request.TagName;
            await courseStoreDbContext.SaveChangesAsync();
            AddResult(tag);
        }
    }
}