using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double ValorTotal { get; set; }
        //public StatusVenda status { get; set; }
    }
}
