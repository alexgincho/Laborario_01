using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborario_01.Models.Services
{
    public interface IProductoService
    {
        public TProducto CreateProduct(TProducto producto);
        public List<TProducto> GetAllProduct();
        public TProducto GetOne(int pk_eProduct);
        public void DeleteProduct(int pk_eProduct);
    }
}
