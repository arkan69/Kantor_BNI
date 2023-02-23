using API.Models;
using FE.Base;

namespace FE.Repositories.Data
{
    public class PelangganRepositories : GeneralRepository<Pelanggan, string>
    {
        private readonly Address address;
        private readonly HttpClient httpClient;
        private readonly string request;
        private readonly IHttpContextAccessor _contextAccessor;
        public PelangganRepositories(Address address, string request = "Pelanggans") : base(address, request)
        {
            this.address = address;
            this.request = request;
            _contextAccessor = new HttpContextAccessor();
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(address.link)
            };
        }
    }
}
