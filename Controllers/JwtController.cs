using Microsoft.AspNetCore.Mvc;
using Lab.Generate;

namespace Lab
{
    public class JwtGeneratorData
    {
        public string User { get; set; }
        public string Role { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        [HttpGet]
        public string Generate(JwtGeneratorData data)
        {
            var generator = new JwtTokenGenerator();
            return generator.Generate(data.User, data.Role);
        }
    }
}