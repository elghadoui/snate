using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using snate.Data;
using snate.Models;
using snate.Models.Ecart;
using snate.Models.Reception;

namespace snate.Controllers
{
    public class VenteEcartController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        public VenteEcartController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index(int? codvar)
        {
            var viewModel=new EcartVM();
            if (codvar == null || codvar == 0)
            {
                codvar = 0;
                
                var TopFive = _appDbContext.top5Acheteurs
                    .FromSqlRaw("call getvwTopAcheteur (@codvar)", new MySqlParameter("@codvar", codvar))
                    .ToList();
                 
                viewModel = new EcartVM
                {
                    VenteEcartlst = _appDbContext.VenteEcarts.ToList(),
                    Produitlst = _appDbContext.ProduitListe.ToList(),
                    topAcheteurlst=TopFive,
                    soldeEcarts = _appDbContext.soldeEcarts2.FromSqlRaw("CALL Getvw_SoldEcart (@codvar)", new MySqlParameter("@codvar", codvar))
                   .ToList()
                    // soldeEcart = _appDbContext.soldeEcarts 


                    // Autres données de tableau de bord...
                };
             
                // Retourner un résultat approprié, par exemple, une erreur ou une vue avec un message d'erreur
                //return BadRequest("ID is required.");
                 
            }
            else
            {

                string strsql = "CALL Getvw_SoldEcart(@codvar)";
                var TopFive = _appDbContext.top5Acheteurs
                   .FromSqlRaw("CALL getvwTopAcheteur (@codvar)", new MySqlParameter("@codvar", codvar))
                   .ToList();
                viewModel = new EcartVM
                {
                    Produitlst = _appDbContext.ProduitListe.ToList(),
                    VenteEcartlst = _appDbContext.VenteEcarts.Where(c => c.codvar == codvar).ToList(),
                    topAcheteurlst = TopFive,
                    soldeEcarts = _appDbContext.soldeEcarts2.FromSqlRaw(strsql, new MySqlParameter("@codvar", codvar))
                   .ToList()
                    // Autres données de tableau de bord...
                };
               
            }
            viewModel.VarieteLst = new List<SelectListItem>();
            foreach (var pd in viewModel.Produitlst)
            {
                viewModel.VarieteLst.Add(new SelectListItem { Text = pd.nomvar, Value = pd.codvar.ToString() });
            }
            return View(viewModel);
        }
    
    }
}
