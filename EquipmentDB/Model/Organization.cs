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
    
    public partial class Organization
    {
        public Organization()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int Organization_ID { get; set; }
        public string OrganizationName { get; set; }
        public string ContactPhone { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
