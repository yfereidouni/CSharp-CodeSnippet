using iCourseStore.BLL.Framework;
using iCourseStore.DAL.CourseStoreDB;
using iCourseStore.Model.Framework;
using iCourseStore.Model.Tags.Commands;
using iCourseStore.Model.Tags.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCourseStore.BLL.Tags.Commands;

//Input = CreateTag and Output = ApplicationServiceResponse<Tag>
public class CreateTagHandler : BaseApplicationServiceHandler<CreateTag, Tag>
{
    public CreateTagHandler(CourseStoreDbContext courseStoreDbContext) : base(courseStoreDbContext) { }

    protected override async Task HandlerRequest(CreateTag request, CancellationToken cancellationToken)
    {
        Tag tag = new Tag
        {
            TagName = request.TagName
        };

        await courseStoreDbContext.Tags.AddAsync(tag);
        await courseStoreDbContext.SaveChangesAsync();

        AddResult(tag);
    }
}