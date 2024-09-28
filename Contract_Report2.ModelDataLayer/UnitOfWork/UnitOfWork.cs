using Contract_Report2.ModelDataLayer.Entities;
using Contract_Report2.ModelDataLayer.Repository;
using Contract_Report2.ModelDataLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Report2.ModelDataLayer.UnitOfWork 
{
    public class UnitOfWork : IDisposable, IUnitOfwork
    {
        private readonly Contract_ReportDBContext _dbContext;

        public UnitOfWork()
        {
            _dbContext = new();
        }
        #region "ForAnyEntity"
        private GenericRepository<Company> _company;

        public GenericRepository<Company> companyUW
        {
            get
            {
                if(_company == null)
                {
                    _company = new GenericRepository<Company>(_dbContext);
                }
                return _company;
            }
        }

        private GenericRepository<Contract> _contract;

        public GenericRepository<Contract > contractUW
        {
            get
            {
                if (_contract == null)
                {
                    _contract = new GenericRepository<Contract>(_dbContext);
                }
                return _contract;
            }
        }

        #endregion

        #region BasicFunctions
        public IEntityDataBaseTransaction BeginTransaction() { return new EntityDatabaseTransaction(_dbContext); }

        public void Dispose() { _dbContext.Dispose(); }

        public void Save() { _dbContext.SaveChanges(); }

    

        #endregion
    }
}
