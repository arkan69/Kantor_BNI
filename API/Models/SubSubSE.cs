using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Models
{
	[Table("SubSub_SE")]
	public class SubSubSE
	{
		[Key, MaxLength(10)]
		public string BMSUBSUB_CODE { get; set; }

		[MaxLength(300)]
		public string BMSUBSUB_DESC { get; set; }

		[MaxLength(10)]
		public string BMSUB_CODE { get; set; }

		[MaxLength(1)]
		public string? ACTIVE { get; set; }

		//relation
		[ForeignKey("BMSUB_CODE")]
		[JsonIgnore]
		public SubSE? SubSE { get; set; }
	}
}
