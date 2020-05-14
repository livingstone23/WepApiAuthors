﻿
using NUnitTestProject.Services;
using System;

namespace NUnitTestProject.Services
{
    public class ServicioDeTransferenciasSinMocks
    {
        public void TransferirEntreCuentas(Cuenta origen, Cuenta destino, decimal montoATransferir)
        {
            if (montoATransferir > origen.Fondos)
            {
                throw new ApplicationException("La cuenta origen no tiene fondos suficientes para realizar la operación");
            }

            origen.Fondos -= montoATransferir;
            destino.Fondos += montoATransferir;
        }
    }
}
