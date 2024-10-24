// File: Services/TeacherService.cs
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;
using System.Collections.Generic;

namespace StudentManagementSystem.Services
{
    public class TeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacherRepository.AddTeacher(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.UpdateTeacher(teacher);
        }

        public void DeleteTeacher(int id)
        {
            _teacherRepository.DeleteTeacher(id);
        }
    }
}
