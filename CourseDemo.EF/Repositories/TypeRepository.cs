using CourseDemo.Core.Models;
using CourseDemo.Core.Repositories;

namespace CourseDemo.EF.Repositories
{
    public class TypeRepository : BaseRepository<CourseType>, ITypeRepository
    {
        public TypeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
