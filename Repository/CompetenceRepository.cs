using System.ComponentModel.DataAnnotations.Schema;
using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{

    public interface ICompetenceRepository
    {
        List<Competence> GetAll();

        List<Competence> GetByType(int TypeId);

        List<Competence> GetByIds(List<int> Ids);
    }
    public class CompetenceRepository : ICompetenceRepository
    {
        private readonly ApplicationDbContext _context;

        public CompetenceRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public List<Competence> GetAll() 
        {
            return _context.Competences.ToList();
        }

        public List<Competence> GetByType(int TypeId) 
        {
            return _context.Competences.Where(c => c.type == TypeId).ToList();
        }
        public List<Competence> GetByIds(List<int> Ids) 
        {
            return _context.Competences.Where(c => Ids.Contains(c.id)).ToList();
        }
    }
}
