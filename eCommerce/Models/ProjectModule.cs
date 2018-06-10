//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ProjectModule
    {
        public int ID { get; set; }
        public int Project_ID { get; set; }
        public int MD_ID { get; set; }
        [Required(ErrorMessage = "Price is Requierd.")]
        [RegularExpression(@"^(?![0.]+$)\d+(\.\d{1,2})?$", ErrorMessage = "Please enter valid Price.")]
        public Nullable<double> Price { get; set; }
        [Required(ErrorMessage = "status is Requierd.")]
        public Nullable<int> Status { get; set; }
        [Required(ErrorMessage = "start Date is Requierd.")]
        public Nullable<System.DateTime> StartDate { get; set; }
        [Required(ErrorMessage = "End Date is Requierd.")]
        public Nullable<System.DateTime> EndDate { get; set; }
        [Required(ErrorMessage = "Hours is Requierd.")]
        [RegularExpression(@"^2[0-4]|([01]?[0-9])$", ErrorMessage = "Please enter valid Hours.")]
        public Nullable<int> NoOfHoursPerDay { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }
    }
}
