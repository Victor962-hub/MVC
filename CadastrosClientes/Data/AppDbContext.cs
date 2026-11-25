using Microsoft.EntityFrameworkCore;
using CadastrosClientes.Models;

namespace CadastrosClientes.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    { }

    public DbSet<Cliente> Clientes {get; set; }
}