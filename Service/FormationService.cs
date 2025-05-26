using CV_back.Entitys;
using CV_back.Repository;

namespace CV_back.Service
{
    //Service appelé par le contrôleur et qui va lui retourner les informations demandées en appelant les différents dépôts nécessaires et construisant la réponse

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
