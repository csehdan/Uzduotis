using System.ComponentModel.DataAnnotations;

namespace MinimalApi.Data.Entities
{
	public class TopNRecord
	{
		[Key]
		public string Username { get; set; }
		public string Lastname { get; set; }
		public string Jobname { get; set; }
		public DateTime Created { get; set; }
	}
}
