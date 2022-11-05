using System;
using grapghql01.IService;
using grapghql01.Models;

namespace grapghql01.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student()

                {
                    Id = i,
                    Name = "Student" + i,
                    Roll = "100" + i
                });
            }
            return students;
        }
    }
}
