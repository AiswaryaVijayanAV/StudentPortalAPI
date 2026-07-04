using AutoMapper;
using StudentPortal.API.DTOs;
using StudentPortal.API.Models;
using StudentPortal.API.Models.StudentPortal.API.Models;

namespace StudentPortal.API.Mapping
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<CreateStudentDto, Student>();

            CreateMap<UpdateStudentDto, Student>();
        }
    }
}