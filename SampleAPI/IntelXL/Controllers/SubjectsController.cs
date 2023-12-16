using IntelXLDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SampleAPI.IntelXL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public SubjectsController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet("GetSubjectsByClassId/{id}")]
        public async Task<IActionResult> GetSubjectsByClassId(int id)
        {
            var subjects = new List<SubjectMaster>();
            try
            {
                string folderPath = Path.Combine(_hostingEnvironment.ContentRootPath, "IntelXL/JsonDataFiles");
                string jsonFilePath = Path.Combine(folderPath, "Subjects.json");
                string jsonData = await System.IO.File.ReadAllTextAsync(jsonFilePath);
                subjects = JsonConvert.DeserializeObject<List<SubjectMaster>>(jsonData);
            }
            catch (Exception)
            {
            }
            return Ok(subjects);
        }
    }
}
