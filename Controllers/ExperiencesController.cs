using CV_back.Service;
using Microsoft.AspNetCore.Mvc;

namespace CV_back.Controllers
{
    [ApiController]
    [Route("CV/Experiences")]
    public class ExperiencesController : ControllerBase
    {
        private readonly ExperiencesService _service;

        public ExperiencesController(ExperiencesService service)
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
