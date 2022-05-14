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
public class CreateTagHandler : IRequestHandler<CreateTag, ApplicationServiceResponse<Tag>>
{
    private readonly CourseStoreDbContext courseStoreDbContext;

    public CreateTagHandler(CourseStoreDbContext courseStoreDbContext)
    {
        this.courseStoreDbContext = courseStoreDbContext;
    }

    public async Task<ApplicationServiceResponse<Tag>> Handle(CreateTag request, CancellationToken cancellationToken)
    {
        Tag tag = new Tag
        {
            Name = request.TagName
        };

        await courseStoreDbContext.Tags.AddAsync(tag);
        await courseStoreDbContext.SaveChangesAsync();

        return new ApplicationServiceResponse<Tag> 
        {
            Result = tag
        };
    }
}
