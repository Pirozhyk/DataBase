//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassPatient111111
{
    using System;
    using System.Collections.Generic;
    
    public partial class Type_of_analysis
    {
        public int ID { get; set; }
        public string Name_analysis { get; set; }
    
        public virtual Analysis Analysis { get; set; }
        public virtual Engineer_1 Engineer_1 { get; set; }
        public virtual Laboratory Laboratory { get; set; }
    }
}
