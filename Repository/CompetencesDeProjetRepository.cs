using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{
    //repository retournant au service la réponse de la database dans une liste d'entity correspondante à la database
    public interface ICompetencesDeProjetRepository 
    {
        List<int> GetByProject(int id);
        List<int> GetByCompetence(int id);
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

        public List<int> GetByCompetence(int id)
        {
            return _context.CompetencesDeProjet.Where(c => c.competence == id).Select(c => c.projet).ToList();
        }
    }
}
