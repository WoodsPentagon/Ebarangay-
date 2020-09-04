//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Barangay
{
    using System;
    using System.Collections.Generic;
    
    public partial class Citizen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Citizen()
        {
            this.CitizenToComplaints = new HashSet<CitizenToComplaint>();
            this.Documents = new HashSet<Document>();
        }
    
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Extension { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string CivilStatus { get; set; }
        public string SpouseName { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string ContactInfo { get; set; }
        public bool Indigent { get; set; }
        public bool SeniorCitizen { get; set; }
        public bool PWD { get; set; }
        public bool Student { get; set; }
        public byte[] Picture { get; set; }
        public int AreaID { get; set; }
        public string VoterID { get; set; }
        public string PrecinctNumber { get; set; }
        public string Philhealth { get; set; }
        public string SSS { get; set; }
        public string PagIbig { get; set; }
    
        public virtual Area Area { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CitizenToComplaint> CitizenToComplaints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
    }
}
