//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iS3.Server.Models.Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project_PersonnelInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> UnitID { get; set; }
        public string Telephone { get; set; }
        public string EMail { get; set; }
        public string Remark { get; set; }
    
        public virtual Project_UnitInfo Project_UnitInfo { get; set; }
    }
}
