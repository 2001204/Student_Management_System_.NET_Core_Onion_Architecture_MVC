using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Core.Student;
using Student.Dataccess.Modal;

namespace Student.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
   
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService ?? throw new ArgumentNullException(nameof(studentService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Students>>> GetAllStudents()
        {
            try
            {
                var students = await _studentService.GetAllStudentsAsync();
                return Ok(students);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving students: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Students>> GetStudentById(int id)
        {
            try
            {
                var student = await _studentService.GetStudentByIdAsync(id);
                if (student == null)
                {
                    return NotFound($"Student with id {id} not found");
                }
                return Ok(student);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving student: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddStudent(Students student)
        {
            try
            {
                if (student == null)
                {
                    return BadRequest("Student object is null");
                }
                await _studentService.AddStudentAsync(student);
                return CreatedAtAction(nameof(GetStudentById), new { id = student.Studentid }, student);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error adding student: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateStudent(int id, Students student)
        {
            try
            {
                if (id != student.Studentid)
                {
                    return BadRequest("Student id mismatch");
                }
                await _studentService.UpdateStudentAsync(student);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating student: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            try
            {
                var existingStudent = await _studentService.GetStudentByIdAsync(id);
                if (existingStudent == null)
                {
                    return NotFound($"Student with id {id} not found");
                }
                await _studentService.DeleteStudentAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error deleting student: {ex.Message}");
            }
        }
    }
}
