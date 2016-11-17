using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    /// <summary>
    /// 交易时间
    /// </summary>
    public class TradeTime
    {
        public virtual TradingDay TradingDay { get; set; }

        public virtual DateTime OpenTime { get; set; }

        public virtual int Durations { get; set; }
    }
}
