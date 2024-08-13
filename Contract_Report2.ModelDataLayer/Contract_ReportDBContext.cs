using Contract_Report2.ModelDataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;      
using System.Text;
using System.Threading.Tasks;
                   

namespace Contract_Report2.ModelDataLayer 
                     
{
   public class Contract_ReportDBContext:DbContext  
    {
        public DbSet<Company> Company { set; get; }
        public DbSet<Contract> Contract { set; get; }
        public DbSet<Contract_Status  > Contract_Status { set; get; }
        public DbSet<Status> Statuses { set; get; }   


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=185.129.118.158;Database=Contarct_Repport;Trusted_Connection=false; TrustServerCertificate=True;MultipleActiveResultSets=true;User Id=mehrnia;Password=Mveyma6303$");
       
        }


    }
    
}
