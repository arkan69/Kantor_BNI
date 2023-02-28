using API.Contexts;
using API.Models;

namespace API.Repositories.Base
{
	public class SubSubSERepositories : GeneralRepository<SubSubSE, string>
	{
		public SubSubSERepositories(MyContext context) : base(context)
		{
		}
	}
}
