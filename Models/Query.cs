using System;
using grapghql01.IService;

namespace grapghql01.Models
{
    public class Query
    {
        readonly IStudentService _studentService ;

        public Query(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public List<Student> Students => _studentService.GetStudents();

    }
}

