//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FutballClup
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamDetails
    {
        public int TeamDetailId { get; set; }
        public Nullable<int> TeamId { get; set; }
        public string TeamColor { get; set; }
        public string TeamCity { get; set; }
        public Nullable<decimal> TeamValue { get; set; }
    
        public virtual Teams Teams { get; set; }
    }
}
