//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aviacompany.Antuh.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meteorology
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meteorology()
        {
            this.Flight = new HashSet<Flight>();
        }
    
        public int ID_Meteorology { get; set; }
        public string Name { get; set; }
        public int ID_Season { get; set; }
        public string WindSpeed { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flight { get; set; }
        public virtual Season Season { get; set; }
    }
}
