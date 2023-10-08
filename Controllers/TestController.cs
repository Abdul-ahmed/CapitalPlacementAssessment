using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementAssessment.Controllers
{
    [ApiController]
    [Route("/")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from APIs";
        }
    }
}