//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy_City.DataFilesApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medication()
        {
            this.AvailabilityPhar = new HashSet<AvailabilityPhar>();
        }
    
        public int IDMedication { get; set; }
        public string NameMedic { get; set; }
        public string GroupMedic { get; set; }
        public string Dosage { get; set; }
        public int ExpirationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailabilityPhar> AvailabilityPhar { get; set; }
    }
}
