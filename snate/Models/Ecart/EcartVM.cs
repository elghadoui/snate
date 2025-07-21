using Microsoft.AspNetCore.Mvc.Rendering;
using snate.Models.Export;
using snate.Models.Reception;

namespace snate.Models.Ecart
{
    public class EcartVM
    {
        public List<VenteEcart>? VenteEcartlst { get; set; }
        public List<ListeProduit>? Produitlst { get; set; }
        public int codvar { get; set; }
        public List<SelectListItem>? VarieteLst { get; set; }
        public List<Top5acheteur>? topAcheteurlst { get; set; }
        public List<SoldeEcart2>? soldeEcarts { get; set; }
    }
}
