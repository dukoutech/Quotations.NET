using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    /// <summary>
    /// 聚合行情
    /// </summary>
    public class AggregationQuotations
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
        /// 交易价格
        /// </summary>
        public virtual decimal TradePrice { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        public virtual DateTime TradeTime { get; set; }

        /// <summary>
        /// 子行情
        /// </summary>
        public virtual IList<Quotations> Children { get; set; }
    }
}
