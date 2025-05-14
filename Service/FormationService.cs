using CV_back.Entitys;
using CV_back.Repository;

namespace CV_back.Service
{


    public interface IFormationService
    {
        List<Formation> GetAll();
    }
    public class FormationService : IFormationService
    {
        private FormationRepository _repoFormation;

        public FormationService(FormationRepository repoFormation) 
        {
            _repoFormation = repoFormation;
        }

        public List<Formation> GetAll() 
        {
            return _repoFormation.GetAll();
        }
    }
}
