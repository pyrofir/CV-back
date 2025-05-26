using CV_back.Entitys;

namespace CV_back.ResponseModel
{
    //Réponse envoyée par les controller
    public class SortCompetences
    {
        public string Type { get; }

        public List<Competence> Competences { get; }


        public SortCompetences(string _Type, List<Competence> _Competences)
        {
            Type = _Type;
            Competences = _Competences;
        }
 
    }
}
