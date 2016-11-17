using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    public class QuotationsConfig
    {
        public virtual string GoodsCode { get; set; }

        public virtual string GoodsName { get; set; }

        public virtual decimal Rate { get; set; }

        public virtual IList<QuotationsConfig> Children { get; set; }
    }
}
