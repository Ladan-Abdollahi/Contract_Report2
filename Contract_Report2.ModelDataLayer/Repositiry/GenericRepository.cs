using Contract_Report2.ModelDataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Report2.ModelDataLayer.Repository
{
    public  class GenericRepository<Tentity> where Tentity : class
    {
        private readonly Contract_ReportDBContext  _context;
        private DbSet<Tentity> _table;
        public GenericRepository(Contract_ReportDBContext context)
        {
            _context = context; 
            _table = context.Set <Tentity>();

        }

        public virtual void create(Tentity entity)
        {
            _table.Add(entity);
        }
        public virtual void update(Tentity entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }
        public virtual Tentity GetById(object id)
        {

           var item= _table.Find(id); 
            if (item == null)
            {
                throw new EntityNotFoundException(typeof(object), id);

            }
           return item;
            
        }
        public virtual void Delete(Tentity entity) {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _table.Attach(entity);
            }
            _table.Remove(entity);
        }
        public virtual void DeleteById(object id)
        {
            var entity = GetById(id);
            Delete (entity);    
        
        }
        public virtual void  DeleteByRange(Expression <Func<Tentity,bool>>wherevariable=null)
        {
            IQueryable<Tentity> query = _table;
            if (wherevariable != null) {  query = query.Where(wherevariable); }
            _table.RemoveRange(query);
        }

        public virtual IEnumerable<Tentity> Get(Expression<Func<Tentity,bool>> whereVariable=null ,
            Func<IQueryable<Tentity>,IOrderedQueryable<Tentity >> orderVariable= null, string joinString = "")
        {
            IQueryable<Tentity> query =_table;  
            if (whereVariable != null)
            {
                query=query.Where(whereVariable);
            }
            if (orderVariable != null)
            {
                  query=orderVariable(query);
            }
            if(joinString != "")
            {
                foreach (string item in joinString.Split(','))
                    { 
                query =query .Include(item);
                }
            }
            return query;
        }

    }
  
}
