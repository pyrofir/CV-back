using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("experience")]
    public class Experience
    {
        public int ID { get; init; }
        public string Poste { get; init; }
        public string Societe { get; init; }
        public string Date { get; init; }
        public string Duree { get; init; }

        public int Type { get; init; }
        public string Context { get; init; }
        public string Objectif { get; init; }
        public string Resultat { get; init; }
        public string SiteWeb { get; init; }
        public string TypeDeSociete { get; init; }
    }
}
