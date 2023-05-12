using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DateNasc { get; set; }

        [Display(Name = "Salario Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dateNasc, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DateNasc = dateNasc;
            SalarioBase = salarioBase;
            Departamento = departamento;
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
