using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MinimalApi.Data.Entities;

namespace MinimalApi.Data
{
	public class UzduotisDb : DbContext
	{
		public DbSet<TopNRecord> TopNRows { get; set; }
		public DbSet<AboveMeanRecord> AboveMeanRows { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			//var connectionString = Environment.GetEnvironmentVariable("BLOGGING_DB_CONNECTION")
			//	?? throw new InvalidOperationException("Database connection string is not set.");
			var cstr = "Data Source=localhost;Initial Catalog=uzduotis;Integrated Security=True;Trust Server Certificate=True";
			//var = Environment.// GetConnectionString("Uzduotis");
			options.UseSqlServer(cstr);
		}
	}
}
