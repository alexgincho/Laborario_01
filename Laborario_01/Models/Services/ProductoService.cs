using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborario_01.Models.Services
{
    public class ProductoService : IProductoService
    {
        public TProducto CreateProduct(TProducto producto)
        {
            TProducto objProduct = null;
            string error = "";
            try
            {
                using (var con = new Db_Context())
                {

                    objProduct.Nombre = producto.Nombre;
                    objProduct.Categoria = producto.Categoria;
                    objProduct.Precio = producto.Precio;
                    objProduct.Descuento = producto.Descuento;

                    con.TProductos.Add(objProduct);
                    con.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return objProduct;
        }

        public void DeleteProduct(int pk_eProduct)
        {
            string error = "2;";
            try
            {
                using (var con = new Db_Context())
                {
                    var objP = GetOne(pk_eProduct);
                    if(objP == null)
                    {
                        throw new Exception();
                    }
                    var obj = con.TProductos.Remove(objP);
                    con.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }

        public List<TProducto> GetAllProduct()
        {
            List<TProducto> lstProduc = null;
            string error = "";
            try
            {
                using (var con = new Db_Context())
                {
                    var lst = con.TProductos.ToList();
                    if(lst.Count <= 0)
                    {
                        throw new Exception();
                    }
                    lstProduc = lst;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return lstProduc;
        }

        public TProducto GetOne(int pk_eProduct)
        {
            TProducto objProduct = null;
            string error = "";
            try
            {
                using (var con = new Db_Context())
                {
                    var obj = con.TProductos.Where(p => p.PkEproducto == pk_eProduct).FirstOrDefault();
                    if(obj == null)
                    {
                        throw new Exception();
                    }
                    objProduct = obj;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return objProduct;
        }
    }
}
