﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace VendasWebMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalPedido(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(p => p.TotalPedidos(inicial, final));
        }
    }
}
