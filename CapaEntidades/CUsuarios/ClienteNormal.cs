using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ClienteNormal:Persona
    {
       // public string producto { get; set; }
        

        #region Atributos Privados

        private string _productoo;


        //Atributos para manejar base de datos
        private string _mensajeError, _valorEscalar;
        private DataTable _dtResultados;

        #endregion


        #region Atributos Públicos

        public string Productoo { get => _productoo; set => _productoo = value; }
        public string MensajeError { get => _mensajeError; set => _mensajeError = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }

        #endregion
    }
}
