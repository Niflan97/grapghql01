using System;
using grapghql01.Models;

namespace grapghql01.IService
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}

