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
    
    public partial class EquipmentLeasing
    {
        public EquipmentLeasing()
        {
            this.EmployeeEquipments = new HashSet<EmployeeEquipment>();
        }
    
        public int EquipmentLeasing_ID { get; set; }
        public int EmployeeOut_ID { get; set; }
        public int EmployeeIn_ID { get; set; }
        public System.DateTime DateOfIssue { get; set; }
        public System.DateTime DateReturn { get; set; }
        public bool IsArchive { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual ICollection<EmployeeEquipment> EmployeeEquipments { get; set; }
    }
}
