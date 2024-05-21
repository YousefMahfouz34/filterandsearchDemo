using filterandsearchdemo.models;

namespace filterandsearchdemo.services
{
    public interface IEmpolyeeServices
    {
       Task< IQueryable<Empolyee>> GetAllAsync(int pageindex,int itemnumber,Filter? filter=null);
        
    }
}
