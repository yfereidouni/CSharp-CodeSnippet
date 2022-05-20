using iCourseStore.Model.Framework;
using iCourseStore.Model.Tags.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace iCourseStore.Model.Tags.Commands;

public class UpdateTag : IRequest<ApplicationServiceResponse<Tag>>
{
    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string TagName { get; set; }
    
    [Required]
    [Range(1,int.MaxValue)]
    public int Id { get; set; }
}
