using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VikingShop.Models.Request;

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
        public Response Register(RegisterRequest request) 
        {
            if(request.UserName.Length > 40 || request.UserName.Length < 3)
            {
                return new Response(false, "UserNameLength");
            }
            if (dbContext.Users.Any(x => x.UserName == request.UserName))
            {
                return new Response(false, "UserNameDublicate");
            }

            if (request.Password.Length < 8 || request.Password.Length > 40)
            {
                return new Response(false, "PasswordLength");
            }
            if (dbContext.Users.Any(x => x.Email == request.Email))
            {
                return new Response(false, "EmailDublicate");
            }
            dbContext.Users.Add(new Models.User()
            {
                UserName = request.UserName,
                Password = request.Password,
                Email = request.Email,
                IsEmailConfirmed = false,
                
            });



            dbContext.SaveChanges();
            return new Response(true, "");

        }
    }
}
