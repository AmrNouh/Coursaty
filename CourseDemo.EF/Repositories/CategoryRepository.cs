using CourseDemo.Core.Models;
using CourseDemo.EF;
using CourseDemo.EF.Repositories;

namespace CourseDemo.Core.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
