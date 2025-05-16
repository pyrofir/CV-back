using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("experiences")]
    public class Experience
    {
        public int id { get; init; }
        public string poste { get; init; }
        public string societe { get; init; }
        public string date { get; init; }
        public string duree { get; init; }

        public int type { get; init; }
        public string context { get; init; }
        public string objectif { get; init; }
        public string resultat { get; init; }
        public string? site_web { get; init; }
        public string? type_de_societe { get; init; }
    }
}
