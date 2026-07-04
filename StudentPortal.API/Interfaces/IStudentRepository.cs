using StudentPortal.API.Models;
using StudentPortal.API.Models.StudentPortal.API.Models;

namespace StudentPortal.API.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudentsAsync();

        Task<Student?> GetStudentByIdAsync(int id);

        Task<Student> AddStudentAsync(Student student);

        Task<Student?> UpdateStudentAsync(int id, Student student);

        Task<bool> DeleteStudentAsync(int id);
    }
}