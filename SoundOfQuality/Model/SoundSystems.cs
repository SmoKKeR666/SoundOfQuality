//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoundOfQuality.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SoundSystems
    {
        public int ID { get; set; }
        public int IDCustomers { get; set; }
        public Nullable<int> IDManagers { get; set; }
        public int IDOrders { get; set; }
        public int IDProducts { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Managers Managers { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
    }
}
