using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{

    public interface ITypeDeCompetenceRepository 
    {
        List<TypeDeCompetence> GetAll();
    }


    public class TypeDeCompetenceRepository : ITypeDeCompetenceRepository
    {
        private readonly ApplicationDbContext _context;

        public TypeDeCompetenceRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public List<TypeDeCompetence> GetAll()
        {
            return _context.TypeDeCompetences.ToList();
        }
    }
}
