using StudentManagementAPI.Models;

namespace StudentManagementAPI.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student? GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(int id, Student updatedStudent);
        void DeleteStudent(int id);
    }
}
