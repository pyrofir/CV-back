using System.ComponentModel.DataAnnotations.Schema;
using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{

    public interface ICompetenceRepository
    {
        List<Competence> GetAll();

        List<Competence> GetByType(int TypeId);
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
    }
}
