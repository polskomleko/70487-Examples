//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NinjaDomain.OldStyleContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clan
    {
        public Clan()
        {
            this.Ninjas = new HashSet<Ninja>();
        }
    
        public int Id { get; set; }
        public string ClanName { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual ICollection<Ninja> Ninjas { get; set; }
    }
}
