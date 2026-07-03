using Escola.Data.Context;
using Microsoft.EntityFrameworkCore;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly EscolaContext db;
    protected readonly DbSet<T> dbSet;

    public Repository(EscolaContext _db)
    {
        db = _db;
        dbSet = _db.Set<T>();
    }

    public async Task<IEnumerable<T>> ObterTodos(){
        return await dbSet.ToListAsync();
    }

    public async Task<T> ObterPorId(int id){
        return await dbSet.FindAsync(id);
    }

    public async Task Adicionar(T t){
        await dbSet.AddAsync(t);
        await db.SaveChangesAsync();
    }

    public async Task Atualizar(T t){
        dbSet.Update(t);
        await db.SaveChangesAsync();
    }

    public async Task Remover(T t){
        dbSet.Remove(t);
        await db.SaveChangesAsync();
    }
}