using API.Contexts;
using API.Models;

namespace API.Repositories.Base
{
	public class SektorEkonomRepositories : GeneralRepository<SektorEkonomi, string>
	{
		public SektorEkonomRepositories(MyContext context) : base(context)
		{
		}
	}
}
