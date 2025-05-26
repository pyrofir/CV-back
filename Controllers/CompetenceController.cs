using CV_back.Service;
using Microsoft.AspNetCore.Mvc;

namespace CV_back.Controllers
{
    //controller pour obtenir les compétences (envoyer sous liste de compétences), soit en brut soit triées par type de compétences (sous liste de SortCompetences)

    [ApiController]
    [Route("CV/Competence")]
    public class CompetenceController : ControllerBase
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




        [HttpGet("sort")]
        public IActionResult GetSort()
        {
            var rep = _service.GetAllSort();
            return Ok(rep);
        }
    }
}
