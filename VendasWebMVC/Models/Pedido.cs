using System;
using VendasWebMVC.Models.Enums;
using System.Collections.Generic;

namespace VendasWebMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double ValorTotal { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public Pedido()
        {
        }

        public Pedido(int id, DateTime date, double valorTotal, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            ValorTotal = valorTotal;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
