//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C.V.ResumeWPF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdditionalInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdditionalInfo()
        {
            this.Guest = new HashSet<Guest>();
        }
    
        public int IDAdditionalInfo { get; set; }
        public Nullable<int> IDCategories { get; set; }
        public bool MilitaryService { get; set; }
        public string Recommendations { get; set; }
        public string Hobby { get; set; }
        public string PersonalQualities { get; set; }
    
        public virtual Categories Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guest { get; set; }
    }
}
