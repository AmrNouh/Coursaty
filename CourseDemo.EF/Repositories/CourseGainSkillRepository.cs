using CourseDemo.Core.Models;
using CourseDemo.EF;
using CourseDemo.EF.Repositories;

namespace CourseDemo.Core.Repositories
{
    public class CourseGainSkillRepository : BaseRepository<CourseGainSkill>, ICourseGainSkillRepository
    {
        public CourseGainSkillRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

    }
}
