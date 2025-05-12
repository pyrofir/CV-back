using System.ComponentModel.DataAnnotations.Schema;

namespace CV_back.Entitys
{
    [Table("tacheexperience")]
    public class TacheExperience
    {
        public int ID { get; init; }
        public string Type { get; init; }
    }
}
