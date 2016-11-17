using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    public class TradingDay
    {
        public virtual string GoodsCode { get; set; }

        public virtual TradingDayTypes TradingDayType { get; set; }

        public virtual DateTime TradeDate { get; set; }

        public virtual IList<TradeTime> TradeTimes { get; set; }

        public virtual DateTime FromDate { get; set; }

        public virtual DateTime UntilDate { get; set; }
    }
}
