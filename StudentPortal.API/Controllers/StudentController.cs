using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.API.DTOs;
using StudentPortal.API.Interfaces;
using StudentPortal.API.Models;
using StudentPortal.API.Models.StudentPortal.API.Models;

namespace StudentPortal.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;

        public StudentController(
            IStudentRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _repository.GetAllStudentsAsync();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _repository.GetStudentByIdAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(CreateStudentDto dto)
        {
            var student = _mapper.Map<Student>(dto);

            var result = await _repository.AddStudentAsync(student);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, UpdateStudentDto dto)
        {
            var student = _mapper.Map<Student>(dto);

            var updatedStudent =
                await _repository.UpdateStudentAsync(id, student);

            if (updatedStudent == null)
            {
                return NotFound();
            }

            return Ok(updatedStudent);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var result = await _repository.DeleteStudentAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return Ok("Student Deleted Successfully");
        }
        [HttpGet("test-error")]
        public IActionResult TestError()
        {
            throw new DivideByZeroException();
        }
    }
}