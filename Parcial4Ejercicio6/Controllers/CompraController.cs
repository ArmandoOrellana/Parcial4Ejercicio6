using Parcial4Ejercicio6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial4Ejercicio6.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pagar()
        {
            Datos n = new Datos();
            n.cantidad = double.Parse(Request.Form["cantidad"].ToString());
            n.valor = double.Parse(Request.Form["valor"].ToString());
            n.subtotal = n.cantidad * n.valor;
            if (n.subtotal<= 100000)
            {
                n.descuento = 0;
                n.total = n.subtotal ;
            }else
            {
                n.descuento = 20;
                n.total = n.subtotal - (n.subtotal * 0.20);
            }
            
            return View("Pagar",n);
        }
    }
}