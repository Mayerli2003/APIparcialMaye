using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAPImaye.Controllers
{
    public class ArticuloController : ApiController
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult Add()
        {
            using (Models.SuperMercadoEntities dato= new Models.SuperMercadoEntities())
            {
                var oArticulo= new Models.Articulo();
                oArticulo.nombre = "Pantalon";
                oArticulo.descripcion = "Verdes";
                oArticulo.precio = Convert.ToDecimal(10);
                oArticulo.cantidad = 11;
                oArticulo.codigo = "1234";
                oArticulo.proveedor = "Doña Maria";
                oArticulo.estado = 1;

                dato.Articulo.Add(oArticulo);
                dato.SaveChanges();
            }
            return Ok("El articulo se registro correctamente");
        }
    }
}
