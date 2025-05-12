using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("competences_de_projet")]
    public class CompetenceDeProjet
    {
        public int ID { get; init; }
        public int Competence { get; init; } 

        public int Projet { get; init; }
    }
}
