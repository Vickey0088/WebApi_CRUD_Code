using System.Security.Claims;
using WebApiCRUDCode.Dto;
using WebApiCRUDCode.Models;

namespace WebApiCRUDCode.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        { 
            _context = context;
        }


        public string DeleteStudent(int studentId)
        {
            var data = _context.Students.FirstOrDefault(x => x.Id == studentId);
            _context.Students.Remove(data);
            _context.SaveChanges();
            return "Student Deleted Successfully";
        } 
        public string UpdateStudent(StudentToUpdate student)
        {
            var data = _context.Students.FirstOrDefault(x => x.Id == student.Id);

            data.StudentName = student.StudentName;
            data.Class = student.Class;
            data.Age = student.Age;
            data.City = student.City;
            data.Email = student.Email;
            data.FName = student.FName;
            data.MName = student.MName;
            data.DOB = student.DOB;

            _context.Students.Update(data);
            _context.SaveChanges();
            return "Student Updated Successfully";
        }

        public string AddStudent(StudentDto student)
        {
            _context.Students.Add(new Students
            {
                StudentName = student.StudentName,
                Class = student.Class,
                Age = student.Age,
                City = student.City,
                Email = student.Email,
                FName = student.FName,
                MName = student.MName,
                DOB = student.DOB
            });

            _context.SaveChanges();
            return "Student Add Successfully";
        }

        public IEnumerable<Students> GetStudents()
        {
            return _context.Students.ToList();
        }

        public string GetStudentById(int id)
        {
            var stu = _context.Students.FirstOrDefault(x => x.Id == id);
            if(stu!= null)
            {
                return _context.Students.ToList().Where(x => x.Id == id).FirstOrDefault().StudentName;
            }
            return stu.StudentName;
        }
    }
}
