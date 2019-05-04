using ArquiteturaAngular.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ArquiteturaAngular.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){} 
    
    public DbSet<Value> Value { get; set; }
    
    }
}