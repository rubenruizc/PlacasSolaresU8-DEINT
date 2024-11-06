using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolaresU8_ENT
{
    public class clsCliente
    {
        #region Atributos
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        private long _telefono;

        public long Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        #endregion

        #region Constructores
        public clsCliente() { }

        public clsCliente(int id, string nombre, string direccion, long telefono)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
        #endregion

    }
}