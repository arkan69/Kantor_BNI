using API.Contexts;
using API.Models;

namespace API.Repositories.Base
{
	public class SubSERepositories : GeneralRepository<SubSE, string>
	{
		public SubSERepositories(MyContext context) : base(context)
		{
		}
	}
}
