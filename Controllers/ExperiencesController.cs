using CV_back.Service;
using Microsoft.AspNetCore.Mvc;

namespace CV_back.Controllers
{
    //controller retournant les expériences, sous la forme de liste de FullExperiences
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


        [HttpGet("{competenceId}")]
        public IActionResult GetByCompetenceId(int competenceId)
        {
            var rep = _service.GetByCompetenceId(competenceId);
            return Ok(rep);
        }
    }
}
