//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class IEntity
    {
        public IEntity()
        {
            this.ISubentities = new HashSet<ISubentity>();
        }
    
        public int IEID { get; set; }
        public string InvestgationEntitys { get; set; }
        public Nullable<int> Gener2 { get; set; }
        public Nullable<int> Gener3 { get; set; }
    
        public virtual ICollection<ISubentity> ISubentities { get; set; }
    }
}
