﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    public class Quotations
    {
        public virtual string GoodsCode { get; set; }

        public virtual string GoodsName { get; set; }

        public virtual decimal TradePrice { get; set; }

        public virtual DateTime TradeTime { get; set; }

        public virtual decimal Rate { get; set; }
    }
}
