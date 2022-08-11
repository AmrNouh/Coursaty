using CourseDemo.Core.Models;
using CourseDemo.EF;
using CourseDemo.EF.Repositories;
namespace CourseDemo.Core.Repositories
{
    public class CourseModuleRepository : BaseRepository<CourseModule>, ICourseModuleRepository
    {
        public CourseModuleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
