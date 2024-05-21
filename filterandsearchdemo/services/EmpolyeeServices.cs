using filterandsearchdemo.context;
using filterandsearchdemo.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace filterandsearchdemo.services
{
    public class EmpolyeeServices : IEmpolyeeServices
    {
        private readonly DemoContext _context;

        public EmpolyeeServices(DemoContext context)
        {
            _context = context;
        }


        //public async Task<IQueryable<Empolyee>> GetAllAsync(int pageIndex, int itemNumber, Filter? filter = null)
        //{
        //    IQueryable<Empolyee> query = _context.Empolyees;

        //    if (filter != null)
        //    {
        //        if (filter.DepartmentId.Count>0)
        //        {
        //            query = query.Where(e => e.DepartmentId == filter.DepartmentId.Value);
        //        }
        //        if (!string.IsNullOrEmpty(filter.occuapation.Count>0))
        //        {
        //            query = query.Where(e => e.occuapation.ToLower().Contains(filter.occuapation.ToLower()));
        //        }
        //        if (filter.performance.HasValue)
        //        {
        //            query = query.Where(e => e.performance == filter.performance.Value);
        //        }
        //    }

        //    var result = query.Skip(itemNumber * (pageIndex - 1)).Take(itemNumber);
        //    return await Task.FromResult(result);
        //}



        public async Task<IQueryable<Empolyee>> GetAllAsync(int pageIndex=1, int itemsPerPage =3, Filter? filter = null)
        {
            IQueryable<Empolyee> query = _context.Empolyees;

            if (filter != null)
            {
                if (filter.DepartmentId != null && filter.DepartmentId.Count > 0)
                {
                    query = query.Where(e => filter.DepartmentId.Contains(e.DepartmentId.Value));
                }

                if (filter.Occuapation != null && filter.Occuapation.Count > 0)
                {
                    query = query.Where(e => filter.Occuapation.Contains(e.occuapation.ToLower()));
                }

                if (filter.BeginPerformance.HasValue|| filter.EndPerformance.HasValue)
                {
                    query = query.Where(e => e.performance >= filter.BeginPerformance.Value&&e.performance<=filter.EndPerformance);
                   
                }
            }
            query = query.Skip(itemsPerPage * (pageIndex - 1)).Take(itemsPerPage);
            return await Task.FromResult(query);
        }
    }




}


