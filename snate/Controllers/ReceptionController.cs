using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using snate.Data;
using snate.Models.Reception;
using System;

namespace snate.Controllers
{
    public class ReceptionController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        public ReceptionController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Reception(int? id)
        {
            if (id == null)
            {
                id = 104;
                // Retourner un résultat approprié, par exemple, une erreur ou une vue avec un message d'erreur
                //return BadRequest("ID is required.");
            }
            var dateParam = DateTime.Now.ToString("yyyy-MM-dd");
            var recapReceptionlst = _appDbContext.recapReceptions
                    .FromSqlRaw("CALL GetvwRecapRecep (@dtejr)", new MySqlParameter("@dtejr", dateParam))
                    .ToList();

            var viewModel = new ReceptionVM
            {
                TvnrecapList = _appDbContext.recapTvn.Where(c => c.codvar == id).First(),
                receptionslst = _appDbContext.receptions.ToList(),
                RecapReceptionlst = recapReceptionlst
                // Autres données de tableau de bord...
            };
            return View(viewModel);
        }
        
    }
}
