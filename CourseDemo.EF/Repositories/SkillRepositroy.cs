using CourseDemo.Core.Models;
using CourseDemo.EF;
using CourseDemo.EF.Repositories;
namespace CourseDemo.Core.Repositories
{
    public class SkillRepositroy : BaseRepository<Skill>, ISkillRepositroy
    {
        public SkillRepositroy(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
