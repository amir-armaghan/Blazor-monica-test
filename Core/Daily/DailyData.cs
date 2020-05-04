using Core.Share;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Daily
{
    public class DailyData : OutputData
    {
        public DailyData()
        {
            Dates = new List<string>();
            DailyOutputIds = new List<DailyOutputId>();
        }

        public List<string> Dates { get; set; }
        public List<DailyOutputId> DailyOutputIds { get; set; }
    }
}
