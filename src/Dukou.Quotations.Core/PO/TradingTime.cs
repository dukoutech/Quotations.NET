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
    public class TradingTime
    {
        /// <summary>
        /// 交易日
        /// </summary>
        public virtual TradingDay TradingDay { get; set; }

        /// <summary>
        /// 开盘时间
        /// </summary>
        public virtual DateTime OpenTime { get; set; }

        /// <summary>
        /// 持续时间（单位分钟）
        /// </summary>
        public virtual int Durations { get; set; }
    }
}
