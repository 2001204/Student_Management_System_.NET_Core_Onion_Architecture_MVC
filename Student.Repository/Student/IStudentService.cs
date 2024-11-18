using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student.Core.Student
{

    public interface IStudentService
    {
        Task<IEnumerable<Students>> GetAllStudentsAsync();
        Task<Students> GetStudentByIdAsync(int studentId);
        Task AddStudentAsync(Students student);
        Task UpdateStudentAsync(Students student);
        Task DeleteStudentAsync(int studentId);
    }

  
}
