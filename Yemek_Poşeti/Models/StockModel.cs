﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yemek_Poşeti.Models
{
    public class StockModel
    {
        public int StockID { get; set; }
        public int ProductID { get; set; }
        public int ProductAmount { get; set; }
    }
}