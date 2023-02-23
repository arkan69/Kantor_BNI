using API.Contexts;
using API.Models;

namespace API.Repositories.Base
{
    public class PelangganRepositories : GeneralRepository<Pelanggan, string>
    {
        public PelangganRepositories(MyContext context) : base(context)
        {
        }
    }
}
