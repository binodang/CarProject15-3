using AutoMapper;
using CarProject.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CarProject.Data.Services;

public class DbService : IDbService
{
    private readonly CarShopContext _db;
    private readonly IMapper _mapper;

    public DbService(CarShopContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    public virtual async Task<List<TDto>> GetAsync<TEntity, TDto>()
        where TEntity : class
        where TDto : class
    {
        //IncludeNavigationsFor<TEntity>();
        var entities = await _db.Set<TEntity>().ToListAsync();
        return _mapper.Map<List<TDto>>(entities);
    }
}
