using Contract_Report2.ModelDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Report2.ModelDataLayer.Entities
{
    [Table("tbContract")]
    public class Contract
    {
       
        [Key]
        public int Id { get; set; }

        [Display(Name = " شماره قرارداد")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}.وارد نشده است ")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "باید حداقل 2 و حداکنر 100 کاراکتر وارد شود. ")]
        public required string ContractNumber { get; set; }

        [Display(Name = " شرح خدمات قرارداد")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}.وارد نشده است ")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "باید حداقل 2 و حداکنر 100 کاراکتر وارد شود. ")]
        public required string ContractDescription { get; set; }
       
        
        [Display(Name = " مبلغ برآورد هزینه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}.وارد نشده است ")]
        [RegularExpression(@"^[a-zA-Z''-'\s]$",
         ErrorMessage = "از این کارکترها نمی توان استفاده کرد.")]
        public float EstimatedCost { get; set; }


        [Display(Name = "بررسی و تدوین")]
        public bool ReviewAndEditting { get; set; }


        [Display(Name = "طرح در کمیته")]
        public bool Committee { get; set; }


        [Display(Name ="تایید کمیته")]
        public bool CommitteeApproval { get; set; }

        [Display(Name = "تاریخ درخواست بودجه")]
        public string? BudgetRequestDate { get; set; }

        [Display(Name = "تاریخ تایید بودجه قرارداد")]
        public string? BudgetApprovalDate { get; set; }

        [Display(Name = "نحوه واگزاری")]
        public string? HowToAssign { get; set; }

        [Display(Name = "مهلت ارايه نرخ")]
        public string? RateDeadline { get; set; }

        [Display(Name = "تاریخ گشایش پاکات")]
        public string? OpeningDate { get; set; }

        [Display(Name ="مبلغ قطعی قرارداد به ریال")]
        public float? FixedAmount { get; set; }
        
        [Display(Name = "ضمانت نامه بانکی")]
        public bool? BankGurantee { get; set; }

        [Display(Name = "نوع قرارداد")]
        public string? ContractType { get; set; }

        [Display(Name = "شروع به کار ")]
        public string? StratWorkDate { get; set; }

        [Display(Name = "پایان به کار ")]
        public string? EndWorkDate { get; set; }

        [Display(Name = " تمدید زمانی به ماه")]
        public int? TimeExtension { get; set; }

        [Display(Name = "پایان کار واقعی")]
        public string? RealFinishDate { get; set; }

        [Display(Name = "واحد متقاضی")]
        public string? ApplicantUnit { get; set; }

    }


}
