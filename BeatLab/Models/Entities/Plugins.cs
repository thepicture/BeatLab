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
    
    public partial class Plugins
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plugins()
        {
            this.Comment_Plugin = new HashSet<Comment_Plugin>();
            this.Order_Plugin = new HashSet<Order_Plugin>();
            this.Price_Plugin = new HashSet<Price_Plugin>();
        }
    
        public int ID_Plugin { get; set; }
        public System.DateTime Date_of_issue_Plugin { get; set; }
        public int ID_Format_Plugin { get; set; }
        public string Name_Plugin { get; set; }
        public byte[] Plugin_file { get; set; }
        public string Version_Plugins { get; set; }
        public bool IsDeleted { get; set; }
        public string Description_plugin { get; set; }
        public byte[] Image_Plugin { get; set; }
        public int ID_User { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment_Plugin> Comment_Plugin { get; set; }
        public virtual Format_Plugin Format_Plugin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Plugin> Order_Plugin { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Price_Plugin> Price_Plugin { get; set; }
    }
}
