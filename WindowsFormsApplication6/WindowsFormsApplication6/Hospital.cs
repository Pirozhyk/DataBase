//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hospital
    {
        public Hospital()
        {
            this.Admin = new HashSet<Admin>();
            this.DOCTORS_1 = new HashSet<DOCTORS_1>();
            this.Engineer_1 = new HashSet<Engineer_1>();
            this.Laboratory = new HashSet<Laboratory>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public Nullable<int> C__of_workers { get; set; }
    
        public virtual ICollection<Admin> Admin { get; set; }
        public virtual ICollection<DOCTORS_1> DOCTORS_1 { get; set; }
        public virtual ICollection<Engineer_1> Engineer_1 { get; set; }
        public virtual ICollection<Laboratory> Laboratory { get; set; }
    }
}