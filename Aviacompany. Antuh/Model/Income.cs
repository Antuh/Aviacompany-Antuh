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
    
    public partial class Income
    {
        public int ID_Income { get; set; }
        public int ID_Ticket { get; set; }
        public decimal GeneralIncome { get; set; }
    
        public virtual Ticket Ticket { get; set; }
    }
}