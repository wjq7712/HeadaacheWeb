//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace HeadacheCDSSWeb.Models
{
    public partial class HDMitigatingFactors
    {
        public int Id { get; set; }
        public string factor { get; set; }
        public int HeadacheDiaryID { get; set; }
    
        public virtual HeadacheDiary HeadacheDiary { get; set; }
    }
    
}
