using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CatalogoProductoService 
    {
        private readonly AppDBContext _context;

        public CatalogoProductoService()
        {
            _context = new AppDBContext();
        }

        public void AgregarCatalogoProducto(string descripcion)
        {
            _context.InsertarCatalogoProducto(descripcion);
        }

        public List<CatalogoProducto> ObtenerCatalogoProductos()
        {
            return _context.ObtenerCatalogoProductos();
        }
    }
}
