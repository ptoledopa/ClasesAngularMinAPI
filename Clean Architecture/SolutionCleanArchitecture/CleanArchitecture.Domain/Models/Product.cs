using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? ProdName { get; set; }
        public string? ProdType { get; set; }
        public decimal? Price { get; set; }
    }
}
