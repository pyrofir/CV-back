using CV_back.Entitys;

namespace CV_back.ResponseModel
{
    public class SortCompetences
    {
        public string Type { get; init; }

        public List<Competence> Competences { get; init; }


        public SortCompetences(string _Type, List<Competence> _Competences)
        {
            Type = _Type;
            Competences = _Competences;
        }
 
    }
}
