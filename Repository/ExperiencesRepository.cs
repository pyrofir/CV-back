using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{

    public interface IExperiencesRepository
    {
        List<Experience> GetAll();
    }
    public class ExperiencesRepository : IExperiencesRepository
    {
        private readonly ApplicationDbContext _context;

        public ExperiencesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Experience> GetAll() 
        {
            return _context.Experiences.ToList();
        }
    }
}
