using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Report2.ModelDataLayer.Entities
{
    [Table("tbSattus")]
    public  class Status
    {
        [Key]
        public int StatusId { get; set; } 
        public string? StatusDescription { get; set; }

    }
}
