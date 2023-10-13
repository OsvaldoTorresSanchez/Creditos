using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class CreditoController : Controller
    {
        // GET: Credito
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Credito credito = new ML.Credito();
            credito.Creditos = new List<object>();
            ML.Result result = BL.Credito.GetAllEF();


            if (result.Correct)
            {
                credito.Creditos = result.Objects;
            }
            else
            {
                ViewBag.Message = result.ErrorMessage; 
            }
            return View(credito);
        }

        public ActionResult Delete( int credito)
        {
            ML.Credito creditos = new ML.Credito();

            creditos.NumeroCredito = credito;

            ML.Result result = BL.Credito.DeleteEF(creditos);
            

            if (result.Correct)
            {
                ViewBag.Message = "Se ha eliminado correctamente el usuario";
            }

            else
            {
                ViewBag.Message = "no se puede eliminar correctemnte el usuario , Error: " + result.ErrorMessage;
            }

            return PartialView("Modal");
        }
    }
}