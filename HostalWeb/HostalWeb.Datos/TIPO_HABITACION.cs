//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostalWeb.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_HABITACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_HABITACION()
        {
            this.HABITACION = new HashSet<HABITACION>();
        }
    
        public int ID_TIPO { get; set; }
        public int CANT_CAMAS { get; set; }
        public int PRECIO { get; set; }
        public int BANIO_PRIVADO { get; set; }
        public string TIPO_CAMA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HABITACION> HABITACION { get; set; }
    }
}
