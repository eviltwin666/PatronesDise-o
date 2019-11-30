﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{

    /// <summary>
    /// Fabrica de Tarjetas de Plata en especifico que hereda de la Fabrica de tarjetas de credito. Retorna un nuevo objeto y se instancia desde aqui.
    /// </summary>
    class FabricaTarjetasPlata : FabricaTarjetas
    {
        private int _limiteCredito;
        private int _cargoAnual;

        public FabricaTarjetasPlata(int limiteCredito, int cargoAnual)
        {
            _limiteCredito = limiteCredito;
            _cargoAnual = cargoAnual;
        }

        public override TarjetaCredito ObtenerTarjetaCredito()
        {
            return new TarjetaPlata(_limiteCredito, _cargoAnual);
        }
    }
}
