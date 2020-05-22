using System.Linq;
using Microsoft.AspNetCore.Mvc;
using task10.Models;

namespace task10.Controllers
{
    [Route("api/patients")]
    [ApiController]
    public class PatientsController
    {
        private readonly PatientDbContext _context;

        public PatientsController(PatientDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(_context.Patient.ToList());
        }
    }
}