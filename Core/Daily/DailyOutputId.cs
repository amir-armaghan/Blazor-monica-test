using Core.Share;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Daily
{
    public class DailyOutputId : OutputId
    {
        public DailyOutputId()
        {
            Results = new List<object>();
        }

        public List<object> Results { get; set; }
    }
}
