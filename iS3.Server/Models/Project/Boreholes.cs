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
    
    public partial class Boreholes
    {
        public Nullable<short> OBJECTID { get; set; }
        public short ID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public Nullable<short> StratumSection { get; set; }
        public Nullable<short> SectionSequence { get; set; }
        public string BoreholeType { get; set; }
        public Nullable<double> TopElevation { get; set; }
        public Nullable<double> BoreholeLength { get; set; }
        public string Mileage { get; set; }
        public Nullable<double> Xcoordinate { get; set; }
        public Nullable<double> Ycoordinate { get; set; }
    }
}