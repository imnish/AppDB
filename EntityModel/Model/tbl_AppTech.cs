//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_AppTech
    {
        public int AppId { get; set; }
        public int TechId { get; set; }
        public int ID { get; set; }
    
        public virtual tbl_App tbl_App { get; set; }
        public virtual tbl_TechnologyMaster tbl_TechnologyMaster { get; set; }
    }
}
