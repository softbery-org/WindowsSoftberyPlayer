// Version: 1.0.0.105
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
    public class Sub
    {
        public int _id = 0;
        public string _start;
        public string _end;
        public int _lenght;
        public string[] _lines = new string[3];
    }
    public class Subtile
    {
        private static string _subtilesFile;
        public Dictionary<int, Sub> SubtileDictionary = new Dictionary<int, Sub>();
        public Dictionary<string, Sub> SubStart = new Dictionary<string, Sub>();

        public Subtile(string path) 
        {
            _subtilesFile = path;
            readSubtile(path);
        }

        private void readSubtile(string path)
        {
            var file = new FileInfo(path);
            if (file.Exists)
            {
                var read = File.ReadAllLines(file.FullName);
                var p = "";
                for (int j = 0; j < read.Length-1; j++)
                {
                    var regexExpTime = $"(\\d+).*(\\d+:\\d+:\\d+,\\d+).+-->.+(\\d+:\\d+:\\d+,\\d+)";
                    
                    var regex = new Regex(regexExpTime);

                    var match = regex.Matches(read[j]);
                    var s = new Sub();

                    if (match.Count>0)
                    {
                        s._lenght = j - 1;
                        s._id = Convert.ToInt32(read[j-1]);
                        var split = match[0].Groups[0].Value.Replace("-->","|");
                        var splits = split.Split('|');
                        s._start = splits[0];
                        s._end = splits[1];
                        var id = read[j-1];
                        var start = match[0].Groups[0].Value;
                        var end = match[0].Groups[1].Value;

                    }
                    else
                    {
                        s._lenght++;
                    }

                    
                    if (!SubtileDictionary.ContainsKey(s._id))
                        SubtileDictionary.Add(s._id, s);
                }
                //System.Windows.Forms.MessageBox.Show(p);
            }
        }

        private TimeSpan tSpan(string time)
        {
            return TimeSpan.Parse(time);
        }

        public Dictionary<string, Sub> GetSubStartTime()
        {
            var d = new Dictionary<string, Sub>();
            foreach (var sub in SubtileDictionary.Values)
            {
                d.Add(sub._start, sub);
            }
            return d;
        }

        public Dictionary<int,Sub> GetSub()
        {
            return SubtileDictionary;
        }
    }
}
