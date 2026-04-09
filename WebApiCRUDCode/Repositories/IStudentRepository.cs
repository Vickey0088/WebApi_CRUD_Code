using WebApiCRUDCode.Models;
using WebApiCRUDCode.Dto;

namespace WebApiCRUDCode.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Students> GetStudents();
        string GetStudentById(int id);
        string AddStudent(StudentDto student);
        string UpdateStudent(StudentToUpdate student);
        string DeleteStudent(int studentId);
    }
}
