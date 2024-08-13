using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Report2.ModelDataLayer.Entities
{
    [Table("tbContract-Status")]
    public class Contract_Status

    {
        [Key]

        public int Id { get; set; }

        public int StatusId { set; get; }
        [ForeignKey("StatusId")]
        public virtual Status status { get; set; }


        public int ContractId { set; get; }
        
        [ForeignKey("ContractId")]
        public virtual Contract contract { get; set; }

    }
}
