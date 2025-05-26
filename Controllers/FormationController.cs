using CV_back.Service;
using Microsoft.AspNetCore.Mvc;

namespace CV_back.Controllers
{
    //Controller retournant les formations sous forme de liste de formations
    [ApiController]
    [Route("CV/Formation")]
    public class FormationController : ControllerBase
    {
        private readonly FormationService _service;

        public FormationController(FormationService service)
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
