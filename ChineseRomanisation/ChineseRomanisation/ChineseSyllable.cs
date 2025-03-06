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

        public string HanyuPinyin
        {
            get
            {
                return Initial.HanyuPinyin + Final.HanyuPinyin;
            }
        }

        public string WadeGiles
        {
            get
            {
                // Here we implement the exceptions specified by the Wade-Giles system.

                if (Final == ChinesePhoneme.E)
                {
                    if (Initial == ChinesePhoneme.G)
                    {
                        return "ko";
                    }
                    if (Initial == ChinesePhoneme.K)
                    {
                        return "k'o";
                    }
                    if (Initial == ChinesePhoneme.H)
                    {
                        return "ho";
                    }
                }

                if (Final == ChinesePhoneme.Ui)
                {
                    if (Initial == ChinesePhoneme.G)
                    {
                        return "kuei";
                    }
                    if (Initial == ChinesePhoneme.K)
                    {
                        return "k'uei";
                    }
                }

                return Initial.WadeGiles + Final.WadeGiles;
            }
        }

        public string ZhuyinFuhao
        {
            get
            {
                return Initial.ZhuyinFuhao + Final.ZhuyinFuhao;
            }
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
            format = format.Replace("HP", HanyuPinyin);
            format = format.Replace("WG", WadeGiles);
            format = format.Replace("ZF", ZhuyinFuhao);

            return format;
        }
    }
}
