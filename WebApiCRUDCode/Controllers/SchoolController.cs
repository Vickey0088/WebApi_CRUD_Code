using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCRUDCode.Dto;
using WebApiCRUDCode.Models;
using WebApiCRUDCode.Repositories;

namespace WebApiCRUDCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        public readonly IStudentRepository _studentRepository;
        public SchoolController(IStudentRepository studentRepository) 
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            var students = _studentRepository.GetStudents();
            return Ok(students);
        }
        [HttpGet("GetStudents/{studentId}")]
        public IActionResult GetStudentById(int studentId)
        {
            var stu = _studentRepository.GetStudentById(studentId);
            if (stu == null)
            {
                return NotFound(); 
            }
            return Ok(stu);
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] StudentDto student)
        {
            var result = _studentRepository.AddStudent(student);
            return Ok(result);
        }

        [HttpPost("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody] StudentToUpdate student)
        {
            var result = _studentRepository.UpdateStudent(student);
            return Ok(result);
        }

        [HttpDelete("DeleteStudent/{studentId}")]
        public IActionResult DeleteStudent(int studentId)
        {
            var result = _studentRepository.DeleteStudent(studentId);
            return Ok(result);
        }
    }
}
