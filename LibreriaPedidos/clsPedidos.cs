using System;
using System.Collections.Generic;

namespace LibreriaPedidos
{
    public partial class clsPedidos
    {

        #region Propiedades
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal MontoIva { get; set; }
        public decimal Total { get; set; }
        public clsClientes Cliente { get; set; }
        #endregion


        #region Constructor
        public clsPedidos()
        {
            Cliente = new clsClientes();
            Items = new List<clsProductosPedidos>();
        }
        #endregion


        #region Metodos
        #endregion

    }
}
