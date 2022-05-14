using iCourseStore.Model.Framework;
using iCourseStore.Model.Tags.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace iCourseStore.Model.Tags.Commands;

public class CreateTag : IRequest<ApplicationServiceResponse<Tag>>
{
    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string TagName { get; set; }
}
