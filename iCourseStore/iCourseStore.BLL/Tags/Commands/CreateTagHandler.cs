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

public class UpdateTagHandler : IRequestHandler<UpdateTag, ApplicationServiceResponse<Tag>>
{
    private readonly CourseStoreDbContext courseStoreDbContext;

    public UpdateTagHandler(CourseStoreDbContext courseStoreDbContext)
    {
        this.courseStoreDbContext = courseStoreDbContext;
    }

    ApplicationServiceResponse<Tag> response = new();

    public async Task<ApplicationServiceResponse<Tag>> Handle(UpdateTag request, CancellationToken cancellationToken)
    {
        ApplicationServiceResponse<Tag> response = new();
        
        Tag tag = courseStoreDbContext.Tags.SingleOrDefault(c => c.Id == request.Id);
        if (tag == null)
        {
            response.AddError($"تگ {request.Id} یافت نشد.");
            await courseStoreDbContext.SaveChangesAsync();
        }
        else
        {
            tag.Name = request.TagName;
            await courseStoreDbContext.SaveChangesAsync();
            response.Result= tag;
        }

        return response;
    }
}