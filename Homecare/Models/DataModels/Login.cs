//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homecare.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Login()
        {
            this.Caretakers = new HashSet<Caretaker>();
        }
    
        public int id_login { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int fk_user_rights_login { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caretaker> Caretakers { get; set; }
        public virtual User_Rights User_Rights { get; set; }
        public virtual Login Login1 { get; set; }
        public virtual Login Login2 { get; set; }
    }
}
