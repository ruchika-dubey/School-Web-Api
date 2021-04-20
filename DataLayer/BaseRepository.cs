using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BaseRepository<T> : IBaseRepository<T> where T : MarksModel
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task Delete(string marksid)
        {
            var employeeModel = await _context.Set<T>().FindAsync(marksid);
            _context.Set<T>().Remove(employeeModel);
            await _context.SaveChangesAsync();
        }

            public async Task<T> Get(string studid)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(m => m.StudentID == studid);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this._context.Set<T>().ToListAsync();
        }

        public async Task Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
