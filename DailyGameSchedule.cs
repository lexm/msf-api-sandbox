using System;
using System.Collections.Generic;
using System.Text;

namespace api_test
{
    public class DailyGameSchedule : IFeedRoot
    {
        public GameSchedule dailygameschedule { get; set; }
    }
}
