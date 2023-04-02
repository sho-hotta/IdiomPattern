using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_3
{
    public class TimeWatch
    {
        private DateTime StartTime { get; set; }

        public void Start()
        {
            StartTime = DateTime.Now;
        }
        public TimeSpan Stop()
        {
            var endTime = DateTime.Now;
            return endTime - StartTime;
        }
    }
}
