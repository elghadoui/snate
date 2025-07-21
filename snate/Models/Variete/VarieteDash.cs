namespace snate.Models.Variete
{
    public class VarieteDash
    {
        public Tvnrecap? TvnrecapList { get; set; }
        public List<Products>? ProductsList { get; set; }
        public List<CondiVariete>? CondVergerList { get; set; }
        public List<MarcheVariete>? marcheVarieteslst { get; set; }
        public List<TypeEcart>? typeEcarts { get; set; }

        public List<ProfileCalibrage>? profilCalibrages { get; set; }
        public List<Emballage_exp>? emballage_Exps { get; set; }
        public List<Defaut_ecart>? defaut_Ecartslst { get; set; }
        public SoldeEcart? soldeEcart { get; set; }
        public List<VenteEcartMois>? VenteEcartMoislst{ get; set; }

        ///TODO:Ajouter defaut ecart
        ///
    }
}
