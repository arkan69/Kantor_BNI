using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Models
{
	[Table("Sektor_Ekonomi")]
	public class SektorEkonomi
	{
		[Key,MaxLength(10)]
		public string BM_CODE { get; set; }

		[MaxLength(300)]
		public string BM_DESC { get; set;}

		[MaxLength(1)]
		public string? ACTIVE { get; set;}

		//relation
		[JsonIgnore]
		public ICollection<SubSE>? SubSEs { get; set; }
	}
}
