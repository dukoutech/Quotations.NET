using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    /// <summary>
    /// 交易日
    /// </summary>
    public class TradingDay
    {
        /// <summary>
        /// 商品代码
        /// </summary>
        public virtual string GoodsCode { get; set; }

        /// <summary>
        /// 交易日类型
        /// </summary>
        public virtual TradingDayTypes TradingDayType { get; set; }

        /// <summary>
        /// 交易日期
        /// </summary>
        public virtual DateTime TradeDate { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        public virtual IList<TradingTime> TradeTimes { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public virtual DateTime FromDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public virtual DateTime UntilDate { get; set; }
    }
}
