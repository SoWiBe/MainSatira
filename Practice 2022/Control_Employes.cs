//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice_2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class Control_Employes
    {
        public int ID_Row { get; set; }
        public int ID_Manager { get; set; }
        public int ID_Employee { get; set; }
        public Nullable<System.DateTime> Data_Create { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Employees Employees1 { get; set; }
    }
}
