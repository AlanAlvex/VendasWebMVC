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

        public Vendedor(int id, string nome, string email, DateTime dateNasc, double salarioBase)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DateNasc = dateNasc;
            SalarioBase = salarioBase;
        }
    }
}
