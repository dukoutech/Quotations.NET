using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    public class SixtyMinutesQuotations
    {
        public virtual string GoodsCode { get; set; }

        public virtual string GoodsName { get; set; }

        public virtual decimal Open { get; set; }

        public virtual decimal High { get; set; }

        public virtual decimal Low { get; set; }

        public virtual decimal Close { get; set; }

        public virtual DateTime OpenTime { get; set; }

        public virtual DateTime CloseTime { get; set; }
    }
}
