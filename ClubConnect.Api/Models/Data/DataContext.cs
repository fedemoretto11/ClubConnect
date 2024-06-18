using ClubConnect.Api.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ClubConnect.Api.Models.Data
{
	public class DataContext : DbContext
	{

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Socio> Socios { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Socio>()
				.Property(e => e.Categoria)
				.HasConversion<string>();

			modelBuilder.Entity<Socio>()
				.Property(e => e.EstaActivo)
				.HasConversion<string>();

			base.OnModelCreating(modelBuilder);
		}

	}
}
