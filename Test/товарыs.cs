//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test
{
    using System;
    using System.Collections.Generic;
    
    public partial class товарыs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public товарыs()
        {
            this.приходТоварыs = new HashSet<приходТоварыs>();
            this.расходТоварыs = new HashSet<расходТоварыs>();
        }
    
        public int Id { get; set; }
        public string НаименованиеТовара { get; set; }
        public int ЦенаЗаЕдиницу { get; set; }
        public int ПроизводителяId { get; set; }
        public Nullable<int> ПроизводительId { get; set; }
        public int ЕдиницаИзмеренияID { get; set; }
        public int КлассификацияТовараId { get; set; }
        public Nullable<int> КлассификациятоваровId { get; set; }
        public int ТараиУпаковкаId { get; set; }
    
        public virtual единицаИзмеренияs единицаИзмеренияs { get; set; }
        public virtual классификациятоваровs классификациятоваровs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<приходТоварыs> приходТоварыs { get; set; }
        public virtual производительs производительs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<расходТоварыs> расходТоварыs { get; set; }
        public virtual тараиУпаковкаs тараиУпаковкаs { get; set; }
    }
}
