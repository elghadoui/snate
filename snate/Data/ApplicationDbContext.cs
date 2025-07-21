

using snate.Models;
using snate.Models.Ecart;
using snate.Models.Export;
using snate.Models.Reception;
using snate.Models.Variete;

namespace snate.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
            
        }
        public DbSet<Products> products { get; set; }
        public DbSet<Tvnrecap> recapTvn { get; set; }
        public DbSet<CondiVariete> condVergers { get; set; }
        public DbSet<MarcheVariete> marcheVarietes { get; set; }
        public DbSet<TypeEcart> typeEcarts { get; set; }
        public DbSet<ProfileCalibrage> calibrageVarietes { get; set; }
        public DbSet<Emballage_exp> emballage_Exp { get; set; }
        public DbSet<Defaut_ecart> defaut_Ecarts { get; set; }
        public DbSet<SoldeEcart> soldeEcarts { get; set; }
        public DbSet<SoldeEcart2> soldeEcarts2 { get; set; }
        public DbSet<VenteEcartMois> _Ecart_Mois { get; set; }
        public DbSet<Reception> receptions { get; set; }
        public DbSet<RecapReception> recapReceptions { get; set; }
        public DbSet<DossierExp> DossierExps { get; set; }
        public DbSet<VenteEcart> VenteEcarts { get; set; }
        public DbSet<ListeProduit> ProduitListe { get; set; }
        public DbSet<Top5acheteur> top5Acheteurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().ToView("vw_exp_destination").HasNoKey();
            modelBuilder.Entity<Tvnrecap>().ToView("vw_dab_tvn_exp_eca").HasNoKey();
            modelBuilder.Entity<CondiVariete>().ToView("vw_db_verger").HasNoKey();
            modelBuilder.Entity<MarcheVariete>().ToView("vw_marche_variete").HasNoKey();
            modelBuilder.Entity<TypeEcart>().ToView("vw_typeecart").HasNoKey();
            modelBuilder.Entity<ProfileCalibrage>().ToView("vw_profile_calibre").HasNoKey();
            modelBuilder.Entity<Emballage_exp>().ToView("vw_emba_exp").HasNoKey();  
            modelBuilder.Entity<Defaut_ecart>().ToView("vw_defaut_ecarts").HasNoKey();
            modelBuilder.Entity<SoldeEcart>().ToView("vw_sold_ecart").HasNoKey();
            modelBuilder.Entity<VenteEcartMois>().ToView("vw_vente_mois").HasNoKey();
            modelBuilder.Entity<Reception>().ToView("vw_reception").HasNoKey();
            modelBuilder.Entity<RecapReception>().HasKey(r => r.codvar);
            modelBuilder.Entity<DossierExp>().ToView("vw_dossier_exp").HasNoKey();
            modelBuilder.Entity<VenteEcart>().ToView("vw_vente_ecart").HasNoKey();
            modelBuilder.Entity<ListeProduit>().ToView("vw_listevariete").HasNoKey();
            modelBuilder.Entity<Top5acheteur>().HasNoKey();
            modelBuilder.Entity<SoldeEcart2>().ToSqlQuery("CALL Getvw_SoldEcart (0)").HasNoKey();
        }
    }
}
