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
    public static class FindUserNameByID
    {
        [FunctionName("FindUserNameByID")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "{ID}")] HttpRequest req, int? ID)
        {
            if (ID is  null)
            {
                return new OkObjectResult("please add the name of the user you would like to find");
            }

            User user = new User();
            UserContext userContext = new UserContext();
            var User = userContext.Users.Where(a => a.UserID == ID)?.FirstOrDefault();
            if (User is null)
            {
                return new OkObjectResult("Could not find a user with that name");
            }
            return new OkObjectResult($"the name for {ID} is {User.UserName}");
        }
    }
}
