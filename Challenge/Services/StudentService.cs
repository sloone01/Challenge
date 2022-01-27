using Challenge.Core.Shared;
using System.Net.Http.Json;

namespace Challenge.Services
{
    public class StudentService : ServiceImpl<Student>
    {
        private IConfiguration configuration;
        public StudentService(IConfiguration config,HttpClient _http) : base(_http)
        {

            configuration = config;

        }

        public override string GetUrl()
        {
           return $"{configuration["ApiUrl"]}Students";
        }
    }
}
