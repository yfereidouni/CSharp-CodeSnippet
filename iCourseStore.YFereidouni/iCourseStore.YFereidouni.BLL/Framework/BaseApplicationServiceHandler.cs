using iCourseStore.YFereidouni.DAL.CourseStoreDB;
using iCourseStore.YFereidouni.Model.Framework;
using MediatR;

namespace iCourseStore.YFereidouni.BLL.Framework;

public abstract class BaseApplicationServiceHandler<TRequest, TResult> : IRequestHandler<TRequest, ApplicationServiceResponse<TResult>>
where TRequest : IRequest<ApplicationServiceResponse<TResult>>, new()
{
    protected readonly CourseStoreDbContext courseStoreDbContext;
    private ApplicationServiceResponse<TResult> response = new();

    public BaseApplicationServiceHandler(CourseStoreDbContext courseStoreDbContext)
    {
        this.courseStoreDbContext = courseStoreDbContext;
    }

    public async Task<ApplicationServiceResponse<TResult>> Handle(TRequest request, CancellationToken cancellationToken)
    {
        await HandleRequest(request, cancellationToken);
        return response;
    }

    protected abstract Task HandleRequest(TRequest request, CancellationToken cancellationToken);
    
    public void AddError(string error)
    {
        response.AddError(error);
    }

    public void AddResult(TResult result)
    {
        response.Result = result;
    }
}
