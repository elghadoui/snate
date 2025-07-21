namespace snate.Models.Reception
{
    public class Reception
    {
        public int numrec { get; set; }
        public int numbl { get; set; }
        public DateOnly dterec { get; set; }
        public string? numveh { get; set; }
        public int codvar { get; set; }
        public string? nomvar { get; set; } = string.Empty;
        public double nbrcai { get; set; }
        public double pdrec { get; set; }
        public string? nomsvar { get; set; } = string.Empty;
        public int refver { get; set; }
        public string? nomadh { get; set; } = string.Empty;
        public string? station { get; set; } = string.Empty;

    }
}
