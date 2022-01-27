using Challenge.Core.Shared;

namespace Challenge.Services
{
    public class CountryService : ServiceImpl<Country>
    {
        private IConfiguration configuration;
        public CountryService(IConfiguration config, HttpClient _http) : base(_http)
        {

            configuration = config;

        }

        public override string GetUrl()
        {
            return $"{configuration["ApiUrl"]}Countries";
        }
    }
}
