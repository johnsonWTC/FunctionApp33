using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;

namespace FunctionApp33
{
    public static class FindUserIDByName
    {
        [FunctionName("FindUserIDByName")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "{Name}")] HttpRequest req,string Name)
        {
            string responseMessage = "";

            User user = new User();
            user.UserName = data.UserName;
            UserContext userContext = new UserContext();
            var username = userContext.Users.Where(a => a.UserName == Name);
            userContext.Users.Add(user);
            userContext.SaveChanges();
            responseMessage = "";
            return new OkObjectResult(responseMessage);
        }
    }
}
