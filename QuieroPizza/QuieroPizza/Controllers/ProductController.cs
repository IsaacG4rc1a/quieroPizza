using QuieroPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
			var producto = new ProductoModel();
			producto.id = 1;
			producto.descripcion = "Pizza 6 quesos";

			var producto2 = new ProductoModel();
			producto2.id = 2;
			producto2.descripcion = "Pizza 4 Estaciones";

			var producto3 = new ProductoModel();
			producto3.id = 3;
			producto3.descripcion = "Pizza Jamon y Queso";

			var listaProducto = new List<ProductoModel>();
			listaProducto.Add(producto);
			listaProducto.Add(producto2);
			listaProducto.Add(producto3);

			return View(listaProducto);
        }
    }
}