using IntelXLDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SampleAPI.IntelXL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public QuestionsController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("GetPracticeQuestions/{id}")]
        public async Task<IActionResult> GetPracticeQuestions(int id)
        {
            var questions = new List<QuestionMaster>();
            try
            {
                string folderPath = Path.Combine(_hostingEnvironment.ContentRootPath, "IntelXL/JsonDataFiles");
                string jsonFilePath = Path.Combine(folderPath, "Practice questions.json");
                string jsonData = await System.IO.File.ReadAllTextAsync(jsonFilePath);
                questions = JsonConvert.DeserializeObject<List<QuestionMaster>>(jsonData);
                var random = new Random();


                var randomizedQuestions = questions?.OrderBy(r => random.Next())
                    .Take(14);

                return Ok(randomizedQuestions);
            }
            catch (Exception ex)
            {
            }
            return Ok(questions);
        }
    }
}
