using Contract_Report2.ModelDataLayer;
using Contract_Report2.ModelDataLayer.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Report2.ModelDataLayer.Repository
{
    public class EntityDatabaseTransaction : IEntityDataBaseTransaction
        
    {
        private readonly IDbContextTransaction _Transaction;

        public EntityDatabaseTransaction(Contract_ReportDBContext Context)
        {
            _Transaction = Context.Database.BeginTransaction();
        }

        public void Commit()

        { //All the requests are done successfully
           _Transaction.Commit();
        }

        public void Dispose()
        {
            //When an error occurred
           _Transaction.Rollback();
        }

        public void RollBack()
        {
            //When an Error occured
            _Transaction.Rollback();   
        }
    }
}
