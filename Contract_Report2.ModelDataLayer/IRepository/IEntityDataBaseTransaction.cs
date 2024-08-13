using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Report2.ModelDataLayer.Repository
{
    public interface IEntityDataBaseTransaction :IDisposable

    {
        void Commit();
        void RollBack();
    }
}
