// Version: 1.0.0.53
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSoftberyPlayer.Subtiles
{
    public class Subtile
    {
        public int Id { get; set; }
        public string StartTime {
            get;
            set;
        }
        public string EndTime { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }

        public Subtile()
        {

        }

        public void AddStartTime(TimeSpan startTime)
        {
            StartTime = $"{startTime.Hours:00}:{startTime.Minutes:00}:{startTime.Seconds:00}"; ;
        }
        public void AddEndTime(TimeSpan endTime)
        {
            EndTime = $"{endTime.Hours:00}:{endTime.Minutes:00}:{endTime.Seconds:00}";
        }
    }
}
