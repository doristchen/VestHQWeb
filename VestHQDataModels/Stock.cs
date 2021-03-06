﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VestHQDataModels
{
    public class Stock
    {
        [Key]
        public string Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(4, MinimumLength = 1), Required]
        public string Ticker { get; set; }

        public ICollection<StockPriceHistory> StockHistories { get; set; }

    }
}
