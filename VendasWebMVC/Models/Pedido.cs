using System;
using VendasWebMVC.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VendasWebMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        
        [DisplayFormat(DataFormatString ="{0:F2}")]
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
