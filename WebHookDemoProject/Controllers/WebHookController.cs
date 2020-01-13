using WebHookDemoProject.Interface;
using System.Web.Http;

namespace WebHookDemoProject.LogClasses
{


    public class WebHookController : ApiController
    {
        private readonly ILogger _logger;
        public WebHookController(ILogger logger)
        {
            _logger = logger;
        }
        public WebHookController()
        {

        }

        [AllowAnonymous]
        
        public void PostData([FromBody]string payLoad)
        {
            _logger.Log(payLoad);
        }
    }
}
 