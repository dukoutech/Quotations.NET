using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.PO
{
    /// <summary>
    /// 行情配置
    /// </summary>
    public class QuotationsConfig
    {
        /// <summary>
        /// 商品代码
        /// </summary>
        public virtual string GoodsCode { get; set; }

        /// <summary>
        /// 商品代码
        /// </summary>
        public virtual string GoodsName { get; set; }

        /// <summary>
        /// 比例
        /// </summary>
        public virtual decimal Rate { get; set; }

        /// <summary>
        /// 子行情配置
        /// </summary>
        public virtual IList<QuotationsConfig> Children { get; set; }
    }
}
