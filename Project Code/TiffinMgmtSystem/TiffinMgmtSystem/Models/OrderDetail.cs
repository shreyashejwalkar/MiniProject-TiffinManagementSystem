//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiffinMgmtSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class OrderDetail
    {
        public int OrderId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "Please select tiffin type")]
        public int TiffinTypeId { get; set; }

        [Required(ErrorMessage = "Please select extras")]
        [Display(Name ="Extras")]
        public int ExtraId { get; set; }

        [Display(Name = "Price")]
        public int Total { get; set; }

        [Required(ErrorMessage = "Count cannot be empty enter in between(0,10)")]
        [Range(0,10)]
        [Display(Name = "Extra Count")]
        public Nullable<short> Count { get; set; }

        [Required(ErrorMessage = "Vendor name cannot be empty")]
        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }
    
        public virtual Extra Extra { get; set; }
        public virtual TiffinDetail TiffinDetail { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
