using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Persona
    {
        #region Atributos Privados

        private byte _idCliente;
        private string _nombree;
        private string _apellidoo;
        private int _identificacion;
        private string _producto;

        #endregion


        #region Atributos Públicos

        public byte IdCliente { get => _idCliente; set => _idCliente = value; }
        public string Nombree { get => _nombree; set => _nombree = value; }
        public string Apellidoo { get => _apellidoo; set => _apellidoo = value; }
        public int Identificacion { get => _identificacion; set => _identificacion = value; }
        public string Producto { get => _producto; set => _producto = value; }

        #endregion




      //  public int Id { get; set; }
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        
    }
}