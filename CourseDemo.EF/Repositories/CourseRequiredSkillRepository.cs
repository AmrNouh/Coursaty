using CourseDemo.Core.Models;
using CourseDemo.EF;
using CourseDemo.EF.Repositories;

namespace CourseDemo.Core.Repositories
{
    public class CourseRequiredSkillRepository : BaseRepository<CourseRequiredSkill>, ICourseRequiredSkillRepository
    {
        public CourseRequiredSkillRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
