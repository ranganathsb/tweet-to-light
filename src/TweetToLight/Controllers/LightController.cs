using System.Web.Http;

namespace TweetToLight.Controllers
{
    public class LightController : ApiController
    {
        public string Get()
        {
            return "Hello, World";
        }

        public RgbResponse Post(RgbRequest request)
        {
            return new RgbResponse { Red = 255, Green = 255, Blue = 255 };
        }
    }

    public class RgbResponse
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }

    public class RgbRequest
    {
        public string Tweet { get; set; }
    }
}
