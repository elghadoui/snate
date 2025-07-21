using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using snate.Data;
using snate.Models.Export;
using snate.Models.Reception;
using System;

namespace snate.Controllers
{
    public class ExportController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        public ExportController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                id = 104;
                // Retourner un résultat approprié, par exemple, une erreur ou une vue avec un message d'erreur
                //return BadRequest("ID is required.");
            }
             
        

            var viewModel = new ExportVM
            {

                Dossierlst = _appDbContext.DossierExps.ToList()

                // Autres données de tableau de bord...
            };
            return View(viewModel);
        }
    }
}
