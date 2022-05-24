using iCourseStore.YFereidouni.Model.Framework;
using iCourseStore.YFereidouni.Model.Tags.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCourseStore.YFereidouni.Model.Tags.Queries;

public class FilterByName: IRequest<ApplicationServiceResponse<List<TagQr>>>
{
    public string? TagName { get; set; }
}
