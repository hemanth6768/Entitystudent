using Entitystudent.Data;
using Entitystudent.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Entitystudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Studentcontext _context;
        public StudentController(Studentcontext context )
        {
            _context=context;
        }
        [HttpPost]
        [Route("ADD")]


        public async Task<IActionResult> Addstudent(Student s)
        {
            await _context.AddAsync(s);
            await _context.SaveChangesAsync();

            return Ok(s);
        }

        [HttpGet]
        [Route("gett-all")]

        public async Task<IActionResult>  getAll()
        {
            var result = await _context.student.ToListAsync();

            return Ok(result);

        }

    }
}
