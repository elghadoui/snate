namespace snate.Models.Ecart
{
    public class VenteEcart
    {
        public int codvar { get; set; }
        public int numvnt { get; set; }
        public DateOnly dtevnt { get; set; }
       
        public string? nomvar { get; set; }
        public string? nomach { get; set; }
        public string? tecar { get; set; } = null;
        public double pdsfru { get; set; }
        public double pdspes { get; set; }
        public double prxkg { get; set; }
        public double montan { get; set; }
        public int numreg { get; set; }

    }
}
