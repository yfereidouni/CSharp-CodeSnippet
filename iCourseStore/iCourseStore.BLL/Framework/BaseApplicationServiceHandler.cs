using iCourseStore.DAL.CourseStoreDB;
using iCourseStore.Model.Framework;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCourseStore.BLL.Framework
{
    public abstract class BaseApplicationServiceHandler<TRequest, TResult> : IRequestHandler<TRequest, ApplicationServiceResponse<TResult>> 
        where TRequest : IRequest<ApplicationServiceResponse<TResult>>
    {
        protected readonly CourseStoreDbContext courseStoreDbContext;
        private ApplicationServiceResponse<TResult> _response=new ApplicationServiceResponse<TResult> ();
        
        public BaseApplicationServiceHandler(CourseStoreDbContext courseStoreDbContext)
        {
            this.courseStoreDbContext = courseStoreDbContext;
        }
        
        public async Task<ApplicationServiceResponse<TResult>> Handle(TRequest request, CancellationToken cancellationToken)
        {
            await HandlerRequest(request, cancellationToken);
            return _response;
        }

        protected abstract Task HandlerRequest(TRequest request, CancellationToken cancellationToken);
        
        public void AddError(string error)
        {
            _response.AddError(error);
        }
        public void AddResult(TResult result)
        {
            _response.Result = result;
        }
    }
}
