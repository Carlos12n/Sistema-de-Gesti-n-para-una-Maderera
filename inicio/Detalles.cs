//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inicio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalles
    {
        public int id_detalle { get; set; }
        public int id_facturaDet { get; set; }
        public int id_maderaDet { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal importeDetalle { get; set; }
    
        public virtual Facturas Facturas { get; set; }
        public virtual TipoMadera TipoMadera { get; set; }
    }
}