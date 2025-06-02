using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{
    //repository retournant au service la réponse de la database dans une liste d'entity correspondante à la database
    public interface IExperiencesRepository
    {
        List<Experience> GetAll();
        List<Experience> GetByIds(List<int> Ids);
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

        public List<Experience> GetByIds(List<int> Ids)
        {
            return _context.Experiences.Where(e => Ids.Contains(e.id)).ToList();
        }
    }
}
