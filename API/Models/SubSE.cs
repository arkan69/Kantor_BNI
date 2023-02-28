using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace API.Models
{
	[Table("Sub_SE")]
	public class SubSE
	{
		[Key, MaxLength(10)]
		public string BMSUB_CODE { get; set; }

		[MaxLength(300)]
		public string BMSUB_DESC { get; set; }

		[MaxLength(10)]
		public string BM_CODE { get;set; }

		[MaxLength(1)]
		public string? ACTIVE { get; set; }

		//relation
		[ForeignKey("BM_CODE")]
		[JsonIgnore]
		public SektorEkonomi? SektorEkonomi { get; set; }

		[JsonIgnore]
		public ICollection<SubSubSE>? SubSubSEs { get; set; }
	}
}
