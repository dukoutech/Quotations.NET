using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Quotations.Service
{
    public interface ITradingDayService
    {
        bool IsTradingDay(DateTime date);

        bool IsTradingTime(DateTime time);
    }
}
