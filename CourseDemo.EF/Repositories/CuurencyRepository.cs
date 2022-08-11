using CourseDemo.Core.Models;
using CourseDemo.EF;
using CourseDemo.EF.Repositories;

namespace CourseDemo.Core.Repositories
{
    public class CuurencyRepository : BaseRepository<Currency>, ICurrencyRepository
    {
        public CuurencyRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
