using CV_back.Service;
using Microsoft.AspNetCore.Mvc;

namespace CV_back.Controllers
{
    [ApiController]
    [Route("CV/Competence")]
    public class CompetenceController :ControllerBase
    {
        private readonly CompetenceService _service;

        public CompetenceController(CompetenceService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var rep = _service.GetAll();
            return Ok(rep);
        }
    }
}
