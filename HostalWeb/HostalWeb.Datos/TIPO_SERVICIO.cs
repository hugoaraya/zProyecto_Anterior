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
    
    public partial class TIPO_SERVICIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_SERVICIO()
        {
            this.COMEDOR = new HashSet<COMEDOR>();
            this.MINUTA = new HashSet<MINUTA>();
        }
    
        public int ID_SERVICIO { get; set; }
        public string DESCRIPCION { get; set; }
        public int PRECIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMEDOR> COMEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MINUTA> MINUTA { get; set; }
    }
}
