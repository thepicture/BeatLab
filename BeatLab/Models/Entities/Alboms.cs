//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeatLab.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alboms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alboms()
        {
            this.Music = new HashSet<Music>();
        }
    
        public int ID_Album { get; set; }
        public int ID_User { get; set; }
        public string Name_Album { get; set; }
        public byte[] Image_Album { get; set; }
        public int ID_Type_Alboms { get; set; }
    
        public virtual Type_Alboms Type_Alboms { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Music> Music { get; set; }
    }
}
