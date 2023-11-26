// Version: 1.0.0.163
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsSoftberyPlayer.Subtiles
{
    public static class fromString
    {
        public static TimeSpan GetTimeSpan(this string txt)
        {
            txt = txt.Trim();
            return TimeSpan.Parse(txt);
        }
    }

    public class SubtileManager
    {
        private static string _subtilesFile;
        private List<Subtile> _startTimeList = new List<Subtile>();
        private Dictionary<string, Subtile> _subtiles = new Dictionary<string, Subtile>();
        public int Count { get => _subtiles.Count; }
        public Subtile[] StartList { get => _startTimeList.ToArray(); }
        public Subtile this[string start_time]
        {
            get => _subtiles[$"{start_time}"];
            set => _subtiles[$"{start_time}"] = value;
        }

        public SubtileManager()
        {

        }

        public SubtileManager(string path)
        {
            _subtilesFile = path;
            readSRT(path);
        }

        public TimeSpan[] StartTimeList()
        {
            var startTimeList = new List<TimeSpan>();
            foreach (var item in _startTimeList)
            {
                startTimeList.Add(fromString.GetTimeSpan(item.StartTime));
            }
            return startTimeList.ToArray();
        }

        public TimeSpan[] StartTimeList(string pattern)
        {
            var startTimeList = new List<TimeSpan>();
            foreach (var item in _subtiles)
            {
                var st = fromString.GetTimeSpan(item.Key);
                var result = $"{st.Hours:00}:{st.Minutes:00}:{st.Seconds:00}";
                this[item.Key] = item.Value;
                startTimeList.Add(fromString.GetTimeSpan(result));
            }
            return startTimeList.ToArray();
        }

        public string getS(ref string txt)
        {
            return txt;
        }

        private void readSRT(string path)
        {
            var file = new FileInfo(path);
            if (file.Exists)
            {
                var read = File.ReadAllLines(file.FullName);

                for (int j = 0; j < read.Length - 1; j++)
                {
                    var regexExpTime = $"(\\d+).*(\\d+:\\d+:\\d+,\\d+).+-->.+(\\d+:\\d+:\\d+,\\d+)";

                    var regex = new Regex(regexExpTime);

                    var match = regex.Matches(read[j]);
                    var s = new Subtile();

                    if (match.Count > 0)
                    {
                        s.Id = Convert.ToInt32(read[j - 1]);
                        var split = match[0].Groups[0].Value.Replace("-->", "|");
                        var splits = split.Split('|');
                        s.StartTime = splits[0];
                        var t = TimeSpan.Parse(s.StartTime);
                        var StartTimeKey = $"{t.Hours:00}:{t.Minutes:00}:{t.Seconds:00}";
                        s.EndTime = splits[1];
                        t = TimeSpan.Parse(s.EndTime);
                        s.EndTime = $"{t.Hours:00}:{t.Minutes:00}:{t.Seconds:00}";
                        s.Text1 = read[j + 1];
                        s.Text2 = read[j + 2];
                        var id = read[j - 1];
                        var start = match[0].Groups[0].Value;
                        var end = match[0].Groups[1].Value;

                        _subtiles.Add(StartTimeKey, s);
                    }
                }
            }
            
        }


        public bool isExist(string txt)
        {
            return _subtiles.ContainsKey(txt);
        }

        private TimeSpan timerSpan(string time)
        {
            return TimeSpan.Parse(time);
        }

        public Subtile GetSubtile(string start_time)
        {
            foreach (var subtile in _subtiles)
            {
                if (subtile.Key == start_time)
                {
                    var s = new Subtile();
                    return subtile.Value;
                }
            }
            return null;
        }

        public Dictionary<string, Subtile> GetSubStartTime()
        {
            var d = new Dictionary<string, Subtile>();
            foreach (var sub in _subtiles.Values)
            {
                d.Add(sub.StartTime, sub);
            }
            return d;
        }

        public Dictionary<string, Subtile> GetSubtiles()
        {
            return _subtiles;
        }
    }
}
