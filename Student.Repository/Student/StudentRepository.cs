using Microsoft.EntityFrameworkCore;
using Student.Dataccess.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Core.Student
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDB _context;

        public StudentRepository(StudentDB context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Students>> GetAllStudentsAsync()
        {
            return await _context.Students
                .Include(s => s.Address)
                .Include(s => s.Enrollments)
                .Include(s => s.Fees)
                .ToListAsync();
        }

        public async Task<Students> GetStudentByIdAsync(int studentId)
        {
            return await _context.Students
                .Include(s => s.Address)
                .Include(s => s.Enrollments)
                .Include(s => s.Fees)
                .FirstOrDefaultAsync(s => s.Studentid == studentId);
        }

        public async Task AddStudentAsync(Students student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStudentAsync(Students student)
        {
            if (student is null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(int studentId)
        {
            var student = await _context.Students.FindAsync(studentId);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }
    }
}
