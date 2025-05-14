using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{

    public interface IFormationRepository 
    {
        List<Formation> GetAll();
    }
    public class FormationRepository : IFormationRepository
    {
        private readonly ApplicationDbContext _context;

        public FormationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Formation> GetAll() 
        {
            return _context.Formations.ToList();
        }


    }
}
