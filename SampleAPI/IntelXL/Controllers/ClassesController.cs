using IntelXLDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SampleAPI.IntelXL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ClassesController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("GetClassesByCourseId/{id}")]
        public async Task<IActionResult> GetClassesByCourseId(int id)
        {
            var classes = new List<ClassMaster>();
            try
            {
                string folderPath = Path.Combine(_hostingEnvironment.ContentRootPath, "IntelXL/JsonDataFiles");
                string jsonFilePath = Path.Combine(folderPath, "Classes.json");
                string jsonData = await System.IO.File.ReadAllTextAsync(jsonFilePath);
                classes = JsonConvert.DeserializeObject<List<ClassMaster>>(jsonData);
            }
            catch (Exception)
            {
            }
            return Ok(classes);
        }
    }
}
