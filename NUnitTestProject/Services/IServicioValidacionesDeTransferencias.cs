using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject.Services
{
    public interface IServicioValidacionesDeTransferencias
    {
        string RealizarValidaciones(Cuenta origen, Cuenta destino, decimal montoATransferir);
    }
}
