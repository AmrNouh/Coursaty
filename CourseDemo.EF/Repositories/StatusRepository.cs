using CourseDemo.Core.Models;
using CourseDemo.EF;
using CourseDemo.EF.Repositories;
namespace CourseDemo.Core.Repositories
{
    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
