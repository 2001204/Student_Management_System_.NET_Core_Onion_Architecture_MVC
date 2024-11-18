using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Core.Student
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
        }

        public async Task<IEnumerable<Students>> GetAllStudentsAsync()
        {
            try
            {
                return await _studentRepository.GetAllStudentsAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Students> GetStudentByIdAsync(int studentId)
        {
            try
            {
                return await _studentRepository.GetStudentByIdAsync(studentId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task AddStudentAsync(Students student)
        {
            try
            {
                await _studentRepository.AddStudentAsync(student);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateStudentAsync(Students student)
        {
            try
            {
                await _studentRepository.UpdateStudentAsync(student);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteStudentAsync(int studentId)
        {
            try
            {
                await _studentRepository.DeleteStudentAsync(studentId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}