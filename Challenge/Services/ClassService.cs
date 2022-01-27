using Challenge.Core.Shared;

namespace Challenge.Services
{
    public class ClassService : ServiceImpl<ClassRecord>
    {
        
        private IConfiguration configuration;
        public ClassService(IConfiguration config, HttpClient _http) : base(_http)
        {

            configuration = config;

        }

        public override string GetUrl()
        {
            return $"{configuration["ApiUrl"]}Class";
        }
    }
}
