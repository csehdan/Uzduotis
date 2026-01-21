using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MinimalApi.Data.Entities;

namespace MinimalApi.Data
{
	public class UzduotisDb : DbContext
	{
		public DbSet<TopNRecord> TopNRows { get; set; }
		public DbSet<AboveMeanRecord> AboveMeanRows { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{

			IConfigurationRoot configuration = new ConfigurationBuilder()
			.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
			.AddJsonFile("appsettings.json")
			.Build();
			var connectionString = configuration.GetConnectionString("DefaultConnection");

			options.UseSqlServer(connectionString);
		}
	}
}
