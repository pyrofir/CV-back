using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{
    //repository retournant au service la réponse de la database dans une liste d'entity correspondante à la database
    public interface ITachesExperiencesRepository 
    {
        List<TacheExperience> GetById(int id);
    }
    public class TachesExperiencesRepository : ITachesExperiencesRepository
    {
        private readonly ApplicationDbContext _context;

        public TachesExperiencesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<TacheExperience> GetById(int id)
        {
            return _context.TachesExperiences.Where(tache => tache.experience == id).ToList();
        }
    }
}
