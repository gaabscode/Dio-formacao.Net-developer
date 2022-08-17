using Microsoft.EntityFrameworkCore;
using WebApplicationAgenda.Entities;

namespace WebApplicationAgenda.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        { 

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}