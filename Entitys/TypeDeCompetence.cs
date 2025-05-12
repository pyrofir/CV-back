using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("typedecompetence")]
    public class TypeDeCompetence
    {
        public int ID { get; init; }
        public string Type { get; init; }
    }
}
