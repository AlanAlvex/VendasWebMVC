using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using VendasWebMVC.Services.Exceptions;

namespace VendasWebMVC.Services
{
    public class VendedorService
    {
        private readonly VendasWebMVCContext _context;

        public VendedorService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Vendedor obj)
        {
            _context.Add(obj);

            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int Id)
        {
            return await _context.Vendedor.Include(p => p.Departamento).FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task RemoveAsync(int Id)
        {
            var obj = await _context.Vendedor.FindAsync(Id);
            _context.Vendedor.Remove(obj);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(Vendedor vendedor)
        {
            bool hasAny = await _context.Vendedor.AnyAsync(p => p.Id == vendedor.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado!");
            }

            try
            {
                _context.Update(vendedor);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
