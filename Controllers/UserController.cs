using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VikingShop.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private VikingShopDbContext dbContext;
        public IConfiguration Configuration { get; }


        public UserController(VikingShopDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            Configuration = configuration;
        }

        [HttpPost]

    

    }
}
