using Microsoft.EntityFrameworkCore;
using StudentPortal.API.Data;
using StudentPortal.API.Interfaces;
using StudentPortal.API.Models;
using StudentPortal.API.Models.StudentPortal.API.Models;

namespace StudentPortal.API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<Student?> UpdateStudentAsync(int id, Student student)
        {
            var existingStudent = await _context.Students.FindAsync(id);

            if (existingStudent == null)
                return null;

            existingStudent.Name = student.Name;
            existingStudent.Email = student.Email;
            existingStudent.Age = student.Age;
            existingStudent.Department = student.Department;

            await _context.SaveChangesAsync();

            return existingStudent;
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return false;

            _context.Students.Remove(student);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}