using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        
        public string Phone()
        {
            return "1-988-999-9999";
        }

        
        public string Address()
        {
            return "USA";
        }
    }
}
