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

    public partial class MT_Evaluation
    {
        public int Project_ID { get; set; }
        public int MT_ID { get; set; }
        [Required(ErrorMessage = "FeedBack is Requierd.")]
        [RegularExpression(@"^[a-zA-Z0-9 ]+$", ErrorMessage = "Please enter valid FeedBack.")]
        public string FeedBack { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
