using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEnITma
{
    [ServiceContract]
    public interface ICatalogoProductoService
    {
        [OperationContract]
        void AgregarCatalogoProducto(string descripcion);

        [OperationContract]
        List<CatalogoProducto> ObtenerCatalogoProductos();
    }
}
