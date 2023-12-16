using IntelXLDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SampleAPI.IntelXL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public TopicsController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("GetTopicsWithSubTopicsBySubjectId/{id}")]
        public async Task<IActionResult> GetTopicsWithSubTopicsBySubjectId(int id)
        {
            var topics = new List<TopicMaster>();
            try
            {
                string folderPath = Path.Combine(_hostingEnvironment.ContentRootPath, "IntelXL/JsonDataFiles");
                string jsonFilePath = Path.Combine(folderPath, "TopicsWithSubTopics.json");
                string jsonData = await System.IO.File.ReadAllTextAsync(jsonFilePath);
                topics = JsonConvert.DeserializeObject<List<TopicMaster>>(jsonData);
            }
            catch (Exception)
            {
            }
            return Ok(topics);
        }
    }
}
