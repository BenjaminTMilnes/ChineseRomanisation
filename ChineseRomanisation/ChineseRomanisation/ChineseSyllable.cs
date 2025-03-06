using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseRomanisation
{
    public class ChineseSyllable
    {
        public ChinesePhoneme Initial { get; set; }
        public ChinesePhoneme Final { get; set; }

        public ChineseSyllable()
        {
            Initial = ChinesePhoneme.None;
            Final = ChinesePhoneme.None;
        }

        public ChineseSyllable(ChinesePhoneme initial, ChinesePhoneme final)
        {
            Initial = initial;
            Final = final;
        }

        public override bool Equals(object obj)
        {
            if (obj is ChineseSyllable)
            {
                var s = obj as ChineseSyllable;

                return s.Initial.Equals(Initial) && s.Final.Equals(Final);
            }

            return false;
        }

        public override string ToString()
        {
            return ToString("HP");
        }

        public string ToString(string format)
        {
            format = format.Replace("HP", Initial.ToString("HP") + Final.ToString("HP"));
            format = format.Replace("WG", Initial.ToString("WG") + Final.ToString("WG"));
            format = format.Replace("ZF", Initial.ToString("ZF") + Final.ToString("ZF"));

            return format;
        }
    }
}
