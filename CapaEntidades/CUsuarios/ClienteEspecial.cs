using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ClienteEspecial : Persona
    {


        #region Atributos Privados

        private double Descuento;
        private string _producto;

        #endregion


        #region Atributos Públicos

        public double Descuento1 { get => Descuento; set => Descuento = value; }
        public string Producto1 { get => _producto; set => _producto = value; }

        #endregion

    }
}
