using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEnITma
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CatalogoProductoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CatalogoProductoService.svc o CatalogoProductoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CatalogoProductoService : ICatalogoProductoService
    {
        private readonly BLL.CatalogoProductoService _service = new BLL.CatalogoProductoService();

        public void AgregarCatalogoProducto(string descripcion)
        {
            _service.AgregarCatalogoProducto(descripcion);
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public List<CatalogoProducto> ObtenerCatalogoProductos()
        {
            return _service.ObtenerCatalogoProductos();
        }
    }
}
