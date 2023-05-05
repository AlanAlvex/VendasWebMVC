using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Data
{
    public class SeedingService
    {
        private VendasWebMVCContext _context;

        public SeedingService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.Vendedor.Any() ||
                _context.Pedido.Any())
            {
                return;
            }

            Departamento d1 = new Departamento(1, "Computers");
            Departamento d2 = new Departamento(2, "Electronics");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Books");

            Vendedor s1 = new Vendedor(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            Pedido r1 = new Pedido(1, new DateTime(2018, 09, 25), 11000.0, StatusVenda.Faturado, s1);
            Pedido r2 = new Pedido(2, new DateTime(2018, 09, 4), 7000.0, StatusVenda.Faturado, s5);
            Pedido r3 = new Pedido(3, new DateTime(2018, 09, 13), 4000.0, StatusVenda.Cancelado, s4);
            Pedido r4 = new Pedido(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Faturado, s1);
            Pedido r5 = new Pedido(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Faturado, s3);
            Pedido r6 = new Pedido(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Faturado, s1);
            Pedido r7 = new Pedido(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Faturado, s2);
            Pedido r8 = new Pedido(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Faturado, s4);
            Pedido r9 = new Pedido(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Pendente, s6);
            Pedido r10 = new Pedido(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Faturado, s6);
            Pedido r11 = new Pedido(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Faturado, s2);
            Pedido r12 = new Pedido(12, new DateTime(2018, 09, 25), 7000.0, StatusVenda.Pendente, s3);
            Pedido r13 = new Pedido(13, new DateTime(2018, 09, 29), 10000.0, StatusVenda.Faturado, s4);
            Pedido r14 = new Pedido(14, new DateTime(2018, 09, 4), 3000.0, StatusVenda.Faturado, s5);
            Pedido r15 = new Pedido(15, new DateTime(2018, 09, 12), 4000.0, StatusVenda.Faturado, s1);
            Pedido r16 = new Pedido(16, new DateTime(2018, 10, 5), 2000.0, StatusVenda.Faturado, s4);
            Pedido r17 = new Pedido(17, new DateTime(2018, 10, 1), 12000.0, StatusVenda.Faturado, s1);
            Pedido r18 = new Pedido(18, new DateTime(2018, 10, 24), 6000.0, StatusVenda.Faturado, s3);
            Pedido r19 = new Pedido(19, new DateTime(2018, 10, 22), 8000.0, StatusVenda.Faturado, s5);
            Pedido r20 = new Pedido(20, new DateTime(2018, 10, 15), 8000.0, StatusVenda.Faturado, s6);
            Pedido r21 = new Pedido(21, new DateTime(2018, 10, 17), 9000.0, StatusVenda.Faturado, s2);
            Pedido r22 = new Pedido(22, new DateTime(2018, 10, 24), 4000.0, StatusVenda.Faturado, s4);
            Pedido r23 = new Pedido(23, new DateTime(2018, 10, 19), 11000.0, StatusVenda.Cancelado, s2);
            Pedido r24 = new Pedido(24, new DateTime(2018, 10, 12), 8000.0, StatusVenda.Faturado, s5);
            Pedido r25 = new Pedido(25, new DateTime(2018, 10, 31), 7000.0, StatusVenda.Faturado, s3);
            Pedido r26 = new Pedido(26, new DateTime(2018, 10, 6), 5000.0, StatusVenda.Faturado, s4);
            Pedido r27 = new Pedido(27, new DateTime(2018, 10, 13), 9000.0, StatusVenda.Pendente, s1);
            Pedido r28 = new Pedido(28, new DateTime(2018, 10, 7), 4000.0, StatusVenda.Faturado, s3);
            Pedido r29 = new Pedido(29, new DateTime(2018, 10, 23), 12000.0, StatusVenda.Faturado, s5);
            Pedido r30 = new Pedido(30, new DateTime(2018, 10, 12), 5000.0, StatusVenda.Faturado, s2);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);

            _context.Pedido.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
