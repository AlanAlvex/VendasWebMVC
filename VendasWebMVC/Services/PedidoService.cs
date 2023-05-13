using System;
using System.Linq;
using VendasWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VendasWebMVC.Services
{
    public class PedidoService
    {
        private readonly VendasWebMVCContext _context;

        public PedidoService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Pedido>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Pedido select obj;

            if (minDate.HasValue)
            {
                result = result.Where(p => p.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(p => p.Date <= maxDate.Value);
            }

            return await result
                .Include(p => p.Vendedor)
                .Include(p => p.Vendedor.Departamento)
                .OrderByDescending(p => p.Date)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Departamento, Pedido>>> FindByDateAgrupAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Pedido select obj;

            if (minDate.HasValue)
            {
                result = result.Where(p => p.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(p => p.Date <= maxDate.Value);
            }

            return await result
                .Include(p => p.Vendedor)
                .Include(p => p.Vendedor.Departamento)
                .OrderByDescending(p => p.Date)
                .GroupBy(p => p.Vendedor.Departamento)
                .ToListAsync();
        }
    }
}
