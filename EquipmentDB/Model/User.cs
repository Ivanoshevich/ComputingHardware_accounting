//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquipmentDB.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int User_ID { get; set; }
        public int Employee_ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
