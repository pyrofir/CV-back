using System.ComponentModel.DataAnnotations.Schema;
using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{

    public interface ICompetenceRepository
    {
        List<Competence> GetAll();
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
    }
}
