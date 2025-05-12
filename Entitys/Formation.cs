using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("formation")]
    public class Formation
    {
        public int ID { get; init; }
        public string Dates { get; init; }
        public string Ecole { get; init; }
        public string Specialisation { get; init; }
        public string Description { get; init; }
    }
}
