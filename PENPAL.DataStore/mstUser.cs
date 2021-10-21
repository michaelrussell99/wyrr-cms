//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PENPAL.DataStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class mstUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mstUser()
        {
            this.trnUserEventDetails = new HashSet<trnUserEventDetail>();
            this.trnUserWalletDetails = new HashSet<trnUserWalletDetail>();
        }
    
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public string PublicKey { get; set; }
        public string SecretKey { get; set; }
        public Nullable<bool> IsSocialLogin { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string DefaultCurrency { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string UserUniqueId { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public string CountryCode { get; set; }
        public string avatar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trnUserEventDetail> trnUserEventDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trnUserWalletDetail> trnUserWalletDetails { get; set; }
    }
}
