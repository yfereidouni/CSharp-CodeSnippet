using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCourseStore.YFereidouni.Model.Framework;

public class ApplicationServiceResponse
{
    private readonly List<string> _errors = new List<string>();
    public bool IsSuccess => !IsFailure;
    public bool IsFailure => _errors.Any();
    public void AddError(string errorMessage)
    {
        _errors.Add(errorMessage);
    }
    public IReadOnlyList<string> Errors => _errors;
}

public class ApplicationServiceResponse<TResult> : ApplicationServiceResponse
{
    public TResult Result { get; set; }
}
