using System.ComponentModel.DataAnnotations.Schema;

namespace snate.Models.Variete
{
    public class MarcheVariete
    {
        public int codvar { get; set; }
        public string nommar { get; set; }
        public double pdExp { get; set; }
        [NotMapped]
        public double pcent { get; set; }
    }
}
