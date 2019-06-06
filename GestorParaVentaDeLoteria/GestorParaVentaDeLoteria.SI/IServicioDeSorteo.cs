﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GestorParaVentaDeLoteria.SI
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioDeSorteo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioDeSorteo
    {

        [OperationContract]
        List<Modelo.Sorteos> Listar();

        [OperationContract]
        void Agregar(Modelo.Sorteos item);
    }
}
