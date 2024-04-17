using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClubConnect.Core.Entidades;


namespace ClubConnect.Data
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Socios> Socios { get; set; }

		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
		
		}
	}
}
