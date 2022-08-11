using CourseDemo.Core.Models;
using CourseDemo.EF;
using CourseDemo.EF.Repositories;

namespace CourseDemo.Core.Repositories
{
    public class LevelRepository : BaseRepository<Level>, ILevelRepository
    {
        public LevelRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
