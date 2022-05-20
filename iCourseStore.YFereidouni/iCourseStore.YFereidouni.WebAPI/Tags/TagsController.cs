using iCourseStore.YFereidouni.DAL.CourseStoreDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iCourseStore.YFereidouni.WebAPI.Tags
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly CourseStoreDbContext courseStoreDbContext;

        public TagsController(CourseStoreDbContext courseStoreDbContext)
        {
            this.courseStoreDbContext = courseStoreDbContext;
        }

    }
}
