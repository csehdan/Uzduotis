using System.ComponentModel.DataAnnotations;

namespace MinimalApi.Data.Entities
{
	public class AboveMeanRecord
	{
		[Key]
		public string Username { get; set; }
		public string Lastname { get; set; }
		public int NWork { get; set; }
	}
}
