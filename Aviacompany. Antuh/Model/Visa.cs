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
    
    public partial class Visa
    {
        public int ID_Visa { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
