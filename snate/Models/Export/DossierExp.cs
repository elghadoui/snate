namespace snate.Models.Export
{
    public class DossierExp
    {
        public int numdos { get; set; }
        public DateOnly dtedep { get; set; }
        public string? numtc { get; set; }
        public string? navire { get; set; }
        public string? nompay { get; set; }
        public string? rsclient { get; set; }
        public string? transite { get; set; }
        public string? transpor { get; set; }
        public string? exporter { get; set; }
        public string? produit { get; set; }
        public int nbrpal { get; set; } = 0;
        public int nbrcol { get; set; } = 0;
        public double pdscom { get; set; } = 0;
        public string? typtrp { get; set; }

    }
}
