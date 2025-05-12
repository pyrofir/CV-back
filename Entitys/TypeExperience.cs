using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("typeexperience")]
    public class TypeExperience
    {
        public int ID { get; init; }
        public string Type { get; init; }
    }
}
