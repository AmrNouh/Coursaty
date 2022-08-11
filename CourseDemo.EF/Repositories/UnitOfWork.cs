using CourseDemo.Core.Repositories;
using System.Threading.Tasks;

namespace CourseDemo.EF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(
            ApplicationDbContext dbContext,
            ICourseRepository Coures,
            ICategoryRepository Categories,
            ICourseGainSkillRepository CourseGainSkills,
            ICourseModuleRepository CourseModules,
            ICourseRequiredSkillRepository CourseRequiredSkills,
            ITypeRepository Types,
            ICurrencyRepository Currencies,
            ILanguageRepository Languages,
            ILevelRepository Levels,
            IModuleRepository Modules,
            ISkillRepositroy Skills,
            IStatusRepository Statuses
            )
        {
            _dbContext = dbContext;
            this.Courses = Coures;
            this.Categories = Categories;
            this.CourseGainSkills = CourseGainSkills;
            this.CourseModules = CourseModules;
            this.CourseRequiredSkills = CourseRequiredSkills;
            this.Types = Types;
            this.Currencies = Currencies;
            this.Languages = Languages;
            this.Levels = Levels;
            this.Modules = Modules;
            this.Skills = Skills;
            this.Statuses = Statuses;
        }

        public ICourseRepository Courses { get; private set; }

        public ICategoryRepository Categories { get; private set; }

        public ICourseGainSkillRepository CourseGainSkills { get; private set; }

        public ICourseModuleRepository CourseModules { get; private set; }

        public ICourseRequiredSkillRepository CourseRequiredSkills { get; private set; }

        public ITypeRepository Types { get; private set; }

        public ICurrencyRepository Currencies { get; private set; }

        public ILanguageRepository Languages { get; private set; }

        public ILevelRepository Levels { get; private set; }

        public IModuleRepository Modules { get; private set; }

        public ISkillRepositroy Skills { get; private set; }

        public IStatusRepository Statuses { get; private set; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
