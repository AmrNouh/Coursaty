using System;
using System.Threading.Tasks;

namespace CourseDemo.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        ICategoryRepository Categories { get; }
        ICourseGainSkillRepository CourseGainSkills { get; }
        ICourseModuleRepository CourseModules { get; }
        ICourseRequiredSkillRepository CourseRequiredSkills { get; }
        ITypeRepository Types { get; }
        ICurrencyRepository Currencies { get; }
        ILanguageRepository Languages { get; }
        ILevelRepository Levels { get; }
        IModuleRepository Modules { get; }
        ISkillRepositroy Skills { get; }
        IStatusRepository Statuses { get; }
        int Complete();
        Task<int> CompleteAsync();

    }
}