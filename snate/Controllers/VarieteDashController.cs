using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using snate.Data;
using snate.Models.Variete;
using System;

namespace snate.Controllers
{
    public class VarieteDashController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        public VarieteDashController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: VarieteDashController
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                id = 104;

                // Retourner un résultat approprié, par exemple, une erreur ou une vue avec un message d'erreur
               // return BadRequest("ID is required.");
            }
            var viewModel = new VarieteDash
            {
                ProductsList = _appDbContext.products.Where(c => c.codvar == id).ToList(),
                TvnrecapList = _appDbContext.recapTvn.Where(c => c.codvar == id).First(),
                CondVergerList = _appDbContext.condVergers.Where(c => c.codvar == id).ToList(),
                marcheVarieteslst = _appDbContext.marcheVarietes.Where(c => c.codvar == id).ToList(),
                profilCalibrages = _appDbContext.calibrageVarietes.Where(c => c.codvar == id).ToList(),
                emballage_Exps = _appDbContext.emballage_Exp.Where(c => c.codvar == id).ToList(),
                soldeEcart = _appDbContext.soldeEcarts.FirstOrDefault(x => x.codvar == id),
                VenteEcartMoislst = _appDbContext._Ecart_Mois.Where(c => c.codvar == id).ToList(),
                defaut_Ecartslst = _appDbContext.defaut_Ecarts.Where(c => c.codvar == id).Take(15).ToList()
                // Autres données de tableau de bord...
            };
            return View(viewModel);
        }

        // GET: VarieteDashController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                id = 104;
                // Retourner un résultat approprié, par exemple, une erreur ou une vue avec un message d'erreur
               // return BadRequest("ID is required.");
            }
            var viewModel = new VarieteDash
            {
                ProductsList = _appDbContext.products.Where(c => c.codvar == id).ToList(),
                TvnrecapList = _appDbContext.recapTvn.Where(c => c.codvar == id).First(),
                CondVergerList = _appDbContext.condVergers.Where(c => c.codvar == id).ToList(),
                marcheVarieteslst = _appDbContext.marcheVarietes.Where(c => c.codvar == id).ToList(),
                defaut_Ecartslst = _appDbContext.defaut_Ecarts.Where(c => c.codvar == id).ToList()
          
            // Autres données de tableau de bord...
        };
            return View(viewModel);
        }

        // GET: VarieteDashController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VarieteDashController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VarieteDashController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VarieteDashController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
     

        // POST: VarieteDashController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    

    }
}
