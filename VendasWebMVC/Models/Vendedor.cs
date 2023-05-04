using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DateNasc { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamentos { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dateNasc, double salarioBase, Departamento departamentos)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DateNasc = dateNasc;
            SalarioBase = salarioBase;
            Departamentos = departamentos;
        }

        public void AddPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }

        public void RemovePedido(Pedido pedido)
        {
            Pedidos.Remove(pedido);
        }

        public double TotalPedidos(DateTime inicio, DateTime final)
        {
            return Pedidos.Where(p => p.Date >= inicio && p.Date <= final).Sum(p => p.ValorTotal);
        }
    }
}
