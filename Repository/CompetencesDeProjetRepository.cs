using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{
    public interface ICompetencesDeProjetRepository 
    {
        List<int> GetByProject(int id);
    }
    public class CompetencesDeProjetRepository : ICompetencesDeProjetRepository
    {
        private readonly ApplicationDbContext _context;
        public CompetencesDeProjetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<int> GetByProject(int id) 
        {
            return _context.CompetencesDeProjet.Where(c => c.projet == id).Select(c => c.competence).ToList();
        }
    }
}
