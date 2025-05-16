using CV_back.data;
using CV_back.Entitys;

namespace CV_back.Repository
{
    public interface ITypeExperienceRepository 
    {
        TypeExperience? GetById(int id);
    }
    public class TypeExperienceRepository : ITypeExperienceRepository
    {
        private readonly ApplicationDbContext _context;
        public TypeExperienceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public TypeExperience? GetById(int id) 
        {
            return _context.TypeExperiences.FirstOrDefault(type => type.id == id);
        }
    }
}
