using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Data;
using MinimalApi.Data.Entities;

namespace MinimalApi
{
	public static class Operations
	{
		public static async Task<List<TopNRecord>> GetTopTen(UzduotisDb db, int n = 10)
		{
			var sqlParam = new SqlParameter("@n", n);
			return await db.TopNRows
				.FromSql($"EXECUTE dbo.GetTopN {sqlParam}")
				.ToListAsync();
		}

		public static async Task<List<AboveMeanRecord>> GetAboveMean(UzduotisDb db, int n = 5)
		{
			var sqlParam = new SqlParameter("@n", n);
			return await db.AboveMeanRows
				.FromSql($"EXECUTE dbo.GetNAboveMean {sqlParam}")
				.ToListAsync();
		}
	}
}
