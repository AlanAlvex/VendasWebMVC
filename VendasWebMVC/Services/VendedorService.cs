using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace VendasWebMVC.Services
{
    public class VendedorService
    {
        private readonly VendasWebMVCContext _context;

        public VendedorService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);

            _context.SaveChanges();
        }

        public Vendedor FindById(int Id)
        {
            return _context.Vendedor.Include(p => p.Departamentos).FirstOrDefault(p => p.Id == Id);
        }

        public void Remove(int Id)
        {
            var obj = _context.Vendedor.FirstOrDefault(p => p.Id == Id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();

        }
    }
}
