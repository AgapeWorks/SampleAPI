using IntelXLDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SampleAPI.IntelXL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CoursesController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("GetAllCourse")]
        public async Task<IActionResult> GetAllCourse()
        {
            var courses = new List<CourseMaster>();
            try
            {
                string folderPath = Path.Combine(_hostingEnvironment.ContentRootPath, "IntelXL/JsonDataFiles");
                string jsonFilePath = Path.Combine(folderPath, "Courses.json");
                string jsonData = await System.IO.File.ReadAllTextAsync(jsonFilePath);
                courses = JsonConvert.DeserializeObject<List<CourseMaster>>(jsonData);
            }
            catch (Exception)
            {
            }
            return Ok(courses);
        }
    }
}
