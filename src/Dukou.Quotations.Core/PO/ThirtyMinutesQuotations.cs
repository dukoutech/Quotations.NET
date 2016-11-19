using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    /// <summary>
    /// 三十分行情
    /// </summary>
    public class ThirtyMinutesQuotations
    {
        /// <summary>
        /// 商品代码
        /// </summary>
        public virtual string GoodsCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public virtual string GoodsName { get; set; }

        /// <summary>
        /// 开盘时间
        /// </summary>
        public virtual DateTime OpenTime { get; set; }

        /// <summary>
        /// 收盘时间
        /// </summary>
        public virtual DateTime CloseTime { get; set; }

        /// <summary>
        /// 开盘价
        /// </summary>
        public virtual decimal Open { get; set; }

        /// <summary>
        /// 最高价
        /// </summary>
        public virtual decimal High { get; set; }

        /// <summary>
        /// 最低价
        /// </summary>
        public virtual decimal Low { get; set; }

        /// <summary>
        /// 收盘价
        /// </summary>
        public virtual decimal Close { get; set; }
    }
}
