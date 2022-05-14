using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCourseStore.Model.Framework;

public class ApplicationServiceResponse
{
    private readonly List<string> errors = new();

    public bool IsSuccess => !IsFailure;

    public bool IsFailure => errors.Any();

    public void AddError(string errorMessage)
    {
        errors.Add(errorMessage);
    }

    public IReadOnlyList<string> Errors => errors;
}

public class ApplicationServiceResponse<TResult> : ApplicationServiceResponse
{
    public TResult Result { get; set; }

}
