using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Report2.ModelDataLayer.Entities
{
    [Table("tbCompany")]
    public class Company
    {
      

        [Key]
        public int CompanyID{ get; set; }

        [Display(Name ="نام شرکت")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="{0}.وارد نشده است ")]
        [StringLength(maximumLength: 100 ,MinimumLength =2,ErrorMessage ="باید حداقل 2 و حداکنر 100 کاراکتر وارد شود. ")]
     //   [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
       //  ErrorMessage = "از این کارکترها نمی توان استفاده کرد.")]
        public string? CompanyName { get; set; }

        [Display(Name = "شماره اقتصادی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}.وارد نشده است ")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "باید حداقل 2 و حداکنر 100 کاراکتر وارد شود. ")]
   //     [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
  // ErrorMessage = "از این کارکترها نمی توان استفاده کرد.")]
        public string? EconomyCode { get; set; }
        [Display(Name = "نام مدیر عامل")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}.وارد نشده است ")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "باید حداقل 2 و حداکنر 100 کاراکتر وارد شود. ")]
     //   [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
 //  ErrorMessage = "از این کارکترها نمی توان استفاده کرد.")]
        public string? ManagerName { get; set; }
        [Display(Name = "کد ملی مدیر عامل")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}.وارد نشده است ")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "باید حداقل 2 و حداکنر 100 کاراکتر وارد شود. ")]
    //    [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
  // ErrorMessage = "از این کارکترها نمی توان استفاده کرد.")]
        public string? ManagerId { get; set; }


        public int? ContractId { set; get; }
        [ForeignKey("ContractId")]
        public virtual Contract contract { get; set; }

        public bool? IsWin { get; set; }
    }
}
