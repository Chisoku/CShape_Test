using StudentManagementAPI.Models;

namespace StudentManagementAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students;

        public StudentService()
        {
            _students = new List<Student>
            {
                new Student { Id = 1, Name = "John Doe", StudentCode = "S001", DateOfBirth = new DateTime(2000, 1, 1) },
                new Student { Id = 2, Name = "Jane Smith", StudentCode = "S002", DateOfBirth = new DateTime(1999, 5, 15) }
            };
        }

        public List<Student> GetAllStudents() => _students;

        public Student? GetStudentById(int id) => _students.FirstOrDefault(s => s.Id == id);

        public void AddStudent(Student student)
        {
            student.Id = _students.Count > 0 ? _students.Max(s => s.Id) + 1 : 1;
            _students.Add(new Student);
        }

        public void UpdateStudent(int id, Student updatedStudent)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.StudentCode = updatedStudent.StudentCode;
                student.DateOfBirth = updatedStudent.DateOfBirth;
            }
        }

        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }
    }
}
