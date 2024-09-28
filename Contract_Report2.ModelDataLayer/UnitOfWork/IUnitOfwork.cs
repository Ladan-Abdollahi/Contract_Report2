using Contract_Report2.ModelDataLayer.Entities;
using Contract_Report2.ModelDataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Contract_Report2.ModelDataLayer.UnitOfWork
{
    public  interface IUnitOfwork

    {
        #region "ForAnyEntity"
        GenericRepository<Company> companyUW { get; }
        GenericRepository<Contract> contractUW { get; }

        #endregion


        #region BasicFunctions
        IEntityDataBaseTransaction BeginTransaction();
        void Dispose();
        void Save();

        #endregion

    }
}
