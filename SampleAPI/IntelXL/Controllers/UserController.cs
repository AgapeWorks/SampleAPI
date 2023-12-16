using IntelXLDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SampleAPI.IntelXL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public UserController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("Login")]
        public async Task<IActionResult> Login(string userId, string password)
        {
            var user = new AppUser();
            try
            {
                var userList = new List<AppUser>();
                string folderPath = Path.Combine(_hostingEnvironment.ContentRootPath, "IntelXL/JsonDataFiles");
                string jsonFilePath = Path.Combine(folderPath, "Users.json");
                string jsonData = await System.IO.File.ReadAllTextAsync(jsonFilePath);
                userList = JsonConvert.DeserializeObject<List<AppUser>>(jsonData);
                user = userList?.Where(c => c.EmailId == userId && c.Password == password).FirstOrDefault();
            }
            catch (Exception)
            {
            }
            return Ok(user);
        }
    }
}
