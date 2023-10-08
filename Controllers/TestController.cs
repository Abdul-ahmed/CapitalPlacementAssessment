using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementAssessment
{
    [ApiController]
    [Route("/")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from API";
        }
    }
}